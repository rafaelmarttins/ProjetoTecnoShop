using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TecnoShop.Domain.EF;
using TecnoShop.Poco;
using TecnoShop.Service.Shop;

namespace TecnoShopApi.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/shop/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private ClienteServico service;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public ClienteController(TecnoShopContext context) : base()
        {
            this.service = new ClienteServico(context);
        }

        /// <summary>
        /// Lista todos os registros da tabela Cliente por Paginação.
        /// </summary>
        /// <param name="take"> Onde inicia os resultados da pesquisa. </param>
        /// <param name="skip"> Quantos registros serão retornados. </param>
        /// <returns> Todos os registros. </returns>
        [HttpGet]
        public ActionResult<List<ClientePoco>> GetAll(int? take = null, int? skip = null)
        {
            try
            {
                List<ClientePoco> lista = this.service.Listar(take, skip);
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Listar todos os registros da tabela Estoque por código de Endereço.
        /// </summary>
        /// <param name="endcod"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("PorEndereco/{endcod:int}")]
        public ActionResult<List<ClientePoco>> GetByEndereco(int endcod)
        {
            try
            {
                List<ClientePoco> listaPoco = this.service.Consultar(cli => cli.CodigoEndereco == endcod).ToList();
                return Ok(listaPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        ///  Lista os registro usando a chave de Cliente.
        /// </summary>
        /// <param name="chave"> Chave de pesquisa. </param>
        /// <returns> Registro localizado. </returns>
        [HttpGet("{chave:int}")]
        public ActionResult<ClientePoco> GetById(int chave)
        {
            try
            {
                ClientePoco poco = this.service.PesquisarPelaChave(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Inclui um novo dado na tabela Cliente.
        /// </summary>
        /// <param name="poco"> Dados que será incluido. </param>
        /// <returns> Dados incluido. </returns>
        [HttpPost]
        public ActionResult<ClientePoco> Post([FromBody] ClientePoco poco)
        {
            try
            {
                ClientePoco novoPoco = this.service.Inserir(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Altera um dado existente na tabela Cliente.
        /// </summary>
        /// <param name="poco"> Altera o dado selecionado. </param>
        /// <returns> Altera o dado selecionado. </returns>
        [HttpPut]
        public ActionResult<ClientePoco> Put([FromBody] ClientePoco poco)
        {
            try
            {
                ClientePoco novoPoco = this.service.Alterar(poco);
                return Ok(novoPoco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        /// <summary>
        /// Exclui um registro existente no recurso, utilizando um id.
        /// </summary>
        /// <param name="chave"> Chave para localização. </param>
        /// <returns> Dado excluido por Id. </returns>
        [HttpDelete("{chave:int}")]
        public ActionResult<ClientePoco> DeleteById(int chave)
        {
            try
            {
                ClientePoco poco = this.service.Excluir(chave);
                return Ok(poco);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
