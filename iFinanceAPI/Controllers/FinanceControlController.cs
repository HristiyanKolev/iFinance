//using AutoMapper;
//using FinanceControlServices.Contracts;
//using FinanceControlServices.Models;
//using Microsoft.AspNetCore.Mvc;

//namespace iFinanceAPI.Controllers
//{
//    /// <summary>
//    /// Finance Control functionality
//    /// </summary>
//    [Route("/api/[Controller]/[action]")]
//    [ApiController]
//    public class FinanceControlController : ControllerBase
//    {
//        private readonly IMapper _mapper;
//        private readonly IEntityService _entityService;
//        private readonly IMonthlyBalanceService _monthlyBalance;
//        private readonly IRecurringEntityService _recurringEntity;

//        public FinanceControlController(IMapper mapper, 
//            IEntityService entityService, 
//            IMonthlyBalanceService monthlyBalance, 
//            IRecurringEntityService recurringEntity
//        {
//            _mapper = mapper;
//            this._entityService = entityService;
//            this._monthlyBalance = monthlyBalance;
//            this._recurringEntity = recurringEntity;
//        }

//        //GET api/[Controller]/[Method]
//        /// <summary>
//        /// Returns a list of all Entities from DB
//        /// </summary>
//        /// <returns></returns>
//        [HttpGet]
//        public ActionResult<IEnumerable<EntityResponseModel>> GetAllEntities()
//        {
//            IEnumerable<EntityServiceModel> service = _entityService.GetEntities();
//            if (service == null)
//            {
//                return NotFound();
//            }

//            IEnumerable<EntityResponseModel> response = _mapper.Map<IEnumerable<EntityResponseModel>>(service);
//            return Ok(response);
//        }

//        //GET api/[Controller]/[Method]
//        /// <summary>
//        /// Returns a list of all MonthlyBalances from DB
//        /// </summary>
//        /// <returns></returns>
//        [HttpGet]
//        public ActionResult<IEnumerable<MonthlyBalanceResponseModel>> GetAllMonthlyBalances()
//        {
//            IEnumerable<MonthlyBalanceServiceModel> service = _monthlyBalance.GetMonthlyBalances();
//            if (service == null)
//            {
//                return NotFound();
//            }

//            IEnumerable<MonthlyBalanceResponseModel> response = _mapper.Map<IEnumerable<MonthlyBalanceResponseModel>>(service);
//            return Ok(response);
//        }

//        //GET api/[Controller]/[Method]
//        /// <summary>
//        /// Returns a list of all QuarterlyBalances from DB
//        /// </summary>
//        /// <returns></returns>
//        [HttpGet]
//        public ActionResult<IEnumerable<MonthlyBalanceResponseModel>> GetAllQuarterlyBalances()
//        {
//            IEnumerable<QuarterlyBalanceServiceModel> service = _quarterlyBalance.GetQuarterlyBalances();
//            if (service == null)
//            {
//                return NotFound();
//            }

//            IEnumerable<QuarterlyBalanceResponseModel> response = _mapper.Map<IEnumerable<QuarterlyBalanceResponseModel>>(service);
//            return Ok(response);
//        }

//        //GET api/[Controller]/[Method]
//        /// <summary>
//        /// Returns a list of all RecurringEntities from DB
//        /// </summary>
//        /// <returns></returns>
//        [HttpGet]
//        public ActionResult<IEnumerable<MonthlyBalanceResponseModel>> GetAllRecurringEntities()
//        {
//            IEnumerable<RecurringEntityServiceModel> service = _recurringEntity.GetRecurringEntities();
//            if (service == null)
//            {
//                return NotFound();
//            }

//            IEnumerable<RecurringEntityResponseModel> response = _mapper.Map<IEnumerable<RecurringEntityResponseModel>>(service);
//            return Ok(response);
//        }

//        //GET api/[Controller]/[Method]/{id}
//        /// <summary>
//        /// Returns a Entity by ID
//        /// </summary>
//        /// <param name="id">Entity ID</param>
//        /// <returns></returns>
//        [HttpGet("{id}", Name = "GetEntityById")]
//        public ActionResult<EntityResponseModel> GetEntityById(int id)
//        {
//            EntityServiceModel service = _entityService.GetEntityByID(id);
//            if (service == null)
//            {
//                return NotFound();
//            }

//            EntityResponseModel response = _mapper.Map<EntityResponseModel>(service);
//            return Ok(response);
//        }

//        //GET api/[Controller]/[Method]{id}
//        /// <summary>
//        /// Returns a Monthly Balance by ID
//        /// </summary>
//        /// <param name="id">MonthlyBalance ID</param>
//        /// <returns></returns>
//        [HttpGet("{id}", Name = "GetMonthlyBalanceById")]
//        public ActionResult<MonthlyBalanceResponseModel> GetMonthlyBalanceById(int id)
//        {
//            MonthlyBalanceServiceModel service = _monthlyBalance.GetMonthlyBalanceByID(id);
//            if (service == null)
//            {
//                return NotFound();
//            }

//            MonthlyBalanceResponseModel response = _mapper.Map<MonthlyBalanceResponseModel>(service);
//            return Ok(response);
//        }

//        //GET api/[Controller]/[Method]/{id}
//        /// <summary>
//        /// Returns a Recurring Entity by ID
//        /// </summary>
//        /// <param name="id">RecurringEntity ID</param>
//        /// <returns></returns>
//        [HttpGet("{id}", Name = "GetRecurringEntityById")]
//        public ActionResult<RecurringEntityResponseModel> GetRecurringEntityById(int id)
//        {
//            RecurringEntityServiceModel service = _recurringEntity.GetRecurringEntityByID(id);
//            if (service == null)
//            {
//                return NotFound();
//            }

//            RecurringEntityResponseModel response = _mapper.Map<RecurringEntityResponseModel>(service);
//            return Ok(response);
//        }
//    }
//}
