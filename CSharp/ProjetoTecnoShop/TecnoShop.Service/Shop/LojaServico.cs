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
    public class LojaServico : GenericService<Loja, LojaPoco>
    {
        public LojaServico(TecnoShopContext context) : base(context)
        { }

        public override List<LojaPoco> Consultar(Expression<Func<Loja, bool>>? predicate = null)
        {
            IQueryable<Loja> query;
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

        public override List<LojaPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Loja> query;
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

        public override List<LojaPoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<Loja, bool>>? predicate = null)
        {
            IQueryable<Loja> query;
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

        public override List<LojaPoco> ConverterPara(IQueryable<Loja> query)
        {
            return query.Select(loj =>
                     new LojaPoco()
                     {
                         CodigoLoja = loj.CodigoLoja,
                         Nome = loj.Nome,
                         Telefone = loj.Telefone,
                         Email = loj.Email,
                         CodigoEndereco = loj.CodigoEndereco,
                         Ativo = loj.Ativo,
                     }
             )
             .ToList();
        }
    }
}
