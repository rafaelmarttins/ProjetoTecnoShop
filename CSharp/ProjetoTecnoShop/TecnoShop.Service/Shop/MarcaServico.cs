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
    public class MarcaServico : GenericService<Marca, MarcaPoco>
    {
        public MarcaServico(TecnoShopContext context) : base(context)
        { }

        public override List<MarcaPoco> Consultar(Expression<Func<Marca, bool>>? predicate = null)
        {
            IQueryable<Marca> query;
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

        public override List<MarcaPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Marca> query;
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

        public override List<MarcaPoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<Marca, bool>>? predicate = null)
        {
            IQueryable<Marca> query;
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
        public override List<MarcaPoco> ConverterPara(IQueryable<Marca> query)
        {
            return query.Select(end =>
                    new MarcaPoco()
                    {
                        CodigoMarca = end.CodigoMarca,
                        NomeMarca = end.NomeMarca,
                        Ativo = end.Ativo,
                    }
            )
            .ToList();
        }
    }
}
