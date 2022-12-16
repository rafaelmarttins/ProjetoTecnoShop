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
    public class EstoqueServico : GenericService<Estoque, EstoquePoco>
    {
        public EstoqueServico(TecnoShopContext context) : base(context)
        { }

        public override List<EstoquePoco> Consultar(Expression<Func<Estoque, bool>>? predicate = null)
        {
            IQueryable<Estoque> query;
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

        public override List<EstoquePoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Estoque> query;
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

        public override List<EstoquePoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<Estoque, bool>>? predicate = null)
        {
            IQueryable<Estoque> query;
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

        public override List<EstoquePoco> ConverterPara(IQueryable<Estoque> query)
        {
            return query.Select(end =>
                     new EstoquePoco()
                     {
                         CodigoEstoque = end.CodigoEstoque,
                         CodigoLoja = end.CodigoLoja,
                         CodigoProduto = end.CodigoProduto,
                         Quantidade = end.Quantidade,
                         Ativo = end.Ativo,
                     }
             )
             .ToList();
        }
    }
}
