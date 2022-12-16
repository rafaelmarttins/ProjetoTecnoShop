using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using TecnoShop.Domain.EF;
using TecnoShop.Poco;
using TecnoShop.Service.Base;

namespace TecnoShop.Service.Shop
{
    public class ProdutoServico : GenericService<Produto, ProdutoPoco>
    {
        public ProdutoServico(TecnoShopContext context) : base(context)
        { }

        public override List<ProdutoPoco> Consultar(Expression<Func<Produto, bool>>? predicate = null)
        {
            IQueryable<Produto> query;
            if (predicate == null)
            {
                query = this.genrepo.Browseable(null);
            }
            else
            {
                query = this.genrepo.Browseable(predicate);
            }
            return this.ConverterPara(query);
        }

        public override List<ProdutoPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Produto> query;
            if (skip == null)
            {
                query = this.genrepo.GetAll();
            }
            else
            {
                query = this.genrepo.GetAll(take, skip);
            }
            return ConverterPara(query);
        }

        public override List<ProdutoPoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<Produto, bool>>? predicate = null)
        {
            IQueryable<Produto> query;
            if (skip == null)
            {
                if (predicate == null)
                {
                    query = this.genrepo.Browseable(null);
                }
                else
                {
                    query = this.genrepo.Browseable(predicate);
                }
            }
            else
            {
                if (predicate == null)
                {
                    query = this.genrepo.GetAll(take, skip);
                }
                else
                {
                    query = this.genrepo.Searchable(take, skip, predicate);
                }
            }
            return this.ConverterPara(query);

        }

        public override List<ProdutoPoco> ConverterPara(IQueryable<Produto> query)
        {
            return query.Select(pro =>
                    new ProdutoPoco()
                    {
                        CodigoProduto = pro.CodigoProduto,
                        NomeProduto = pro.NomeProduto,
                        CodigoMarca = pro.CodigoMarca,
                        CodigoCategoria = pro.CodigoCategoria,
                        Ano = pro.Ano,
                        Preco = pro.Preco,
                        Ativo = pro.Ativo,
                    }
            )
            .ToList();
        }
    }
}
