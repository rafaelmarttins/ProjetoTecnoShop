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
    public class VendaServico : GenericService<Venda, VendaPoco>
    {
        public VendaServico(TecnoShopContext context) : base(context)
        { }

        public override List<VendaPoco> Consultar(Expression<Func<Venda, bool>>? predicate = null)
        {
            IQueryable<Venda> query;
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

        public override List<VendaPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<Venda> query;
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

        public override List<VendaPoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<Venda, bool>>? predicate = null)
        {
            IQueryable<Venda> query;
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

        public override List<VendaPoco> ConverterPara(IQueryable<Venda> query)
        {
            return query.Select(fun =>
                    new VendaPoco()
                    {
                        CodigoVenda = fun.CodigoVenda,
                        CodigoCliente = fun.CodigoCliente,
                        VendaStatus = fun.VendaStatus,
                        DataVenda = fun.DataVenda,
                        DataPreparo = fun.DataPreparo,
                        DataEnvio = fun.DataEnvio,
                        CodigoLoja = fun.CodigoLoja,
                        CodigoFuncionario = fun.CodigoFuncionario,
                        Ativo = fun.Ativo,
                    }
            )
            .ToList();
        }
    }
}
