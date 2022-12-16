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
    public class VendaItemServico : GenericService<VendaItem, VendaItemPoco>
    {
        public VendaItemServico(TecnoShopContext context) : base(context)
        { }

        public override List<VendaItemPoco> Consultar(Expression<Func<VendaItem, bool>>? predicate = null)
        {
            IQueryable<VendaItem> query;
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

        public override List<VendaItemPoco> Listar(int? take = null, int? skip = null)
        {
            IQueryable<VendaItem> query;
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

        public override List<VendaItemPoco> Vasculhar(int? take = null, int? skip = null, Expression<Func<VendaItem, bool>>? predicate = null)
        {
            IQueryable<VendaItem> query;
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

        public override List<VendaItemPoco> ConverterPara(IQueryable<VendaItem> query)
        {
            return query.Select(ven =>
                    new VendaItemPoco()
                    {
                        CodigoVendaItem = ven.CodigoVendaItem,
                        CodigoVenda = ven.CodigoVenda,
                        CodigoItem = ven.CodigoItem,
                        CodigoProduto = ven.CodigoProduto,
                        Quantidade = ven.Quantidade,
                        Preco = ven.Preco,
                        Desconto = ven.Desconto,
                        Ativo = ven.Ativo,
                    }
            )
            .ToList();
        }
    }
}
