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
    public class GerenteServico : GenericService<Gerente, GerentePoco>
    {
        public GerenteServico(TecnoShopContext context) : base(context)
        { }

        public override List<GerentePoco> Consultar(Expression<Func<Gerente, bool>>? predicate = null)
        {
            IQueryable<Gerente> query;
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

        public override List<GerentePoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Gerente> query;
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

        public override List<GerentePoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<Gerente, bool>>? predicate = null)
        {
            IQueryable<Gerente> query;
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

        public override List<GerentePoco> ConverterPara(IQueryable<Gerente> query)
        {
            return query.Select(gen =>
                     new GerentePoco()
                     {
                         CodigoGerente = gen.CodigoGerente,
                         Nome = gen.Nome,
                         SobreNome = gen.SobreNome,
                         Email = gen.Email,
                         Telefone = gen.Telefone,
                         Ativo = gen.Ativo,
                         CodigoLoja = gen.CodigoLoja,
                     }
             )
             .ToList();
        }
    }
}
