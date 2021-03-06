using BlInfoApiWrapper.Stores;

namespace BlInfoApiWrapper
{
    public class ClientSession
    {
        private readonly AuthenticationSession _authenticationSession;
        private readonly string _userKey;
		private CommonStore _commonStore;
        private AccountStore _accountStore;
        private ArticleStore _articleStore;
        private CostBearerStore _costBearerStore;
        private CustomerStore _customerStore;
        private CustomerInvoiceStore _customerInvoiceStore;
        private JournalStore _journalStore;
        private OrderStore _orderStore;
        private ProjectStore _projectStore;
        private SupplierInvoiceStore _supplierInvoiceStore;
        private SupplierStore _supplierStore;
        private DocumentStore _documentStore;
        private DetailsStore _detailsStore;
        private PayrollStore _payrollStore;
        private CostCenterStore _costCenterStore;
        private FinancialYearStore _financialYearStore;
        private MetaStore _metaStore;

        public CommonStore CommonStore => _commonStore ?? (_commonStore = new CommonStore(_authenticationSession.AccessToken, _userKey));
        public AccountStore AccountStore => _accountStore ?? (_accountStore = new AccountStore(_authenticationSession.AccessToken, _userKey));
        public ArticleStore ArticleStore => _articleStore ?? (_articleStore = new ArticleStore(_authenticationSession.AccessToken, _userKey));
        public CostBearerStore CostBearerStore => _costBearerStore ?? (_costBearerStore = new CostBearerStore(_authenticationSession.AccessToken, _userKey));
        public CustomerStore CustomerStore => _customerStore ?? (_customerStore = new CustomerStore(_authenticationSession.AccessToken, _userKey));
        public CustomerInvoiceStore CustomerInvoiceStore => _customerInvoiceStore ?? (_customerInvoiceStore = new CustomerInvoiceStore(_authenticationSession.AccessToken, _userKey));
        public JournalStore JournalStore => _journalStore ?? (_journalStore = new JournalStore(_authenticationSession.AccessToken, _userKey));
        public OrderStore OrderStore => _orderStore ?? (_orderStore = new OrderStore(_authenticationSession.AccessToken, _userKey));
        public ProjectStore ProjectStore => _projectStore ?? (_projectStore = new ProjectStore(_authenticationSession.AccessToken, _userKey));
        public SupplierInvoiceStore SupplierInvoiceStore => _supplierInvoiceStore ?? (_supplierInvoiceStore = new SupplierInvoiceStore(_authenticationSession.AccessToken, _userKey));
        public SupplierStore SupplierStore => _supplierStore ?? (_supplierStore = new SupplierStore(_authenticationSession.AccessToken, _userKey));
        public DocumentStore DocumentStore => _documentStore ?? (_documentStore = new DocumentStore(_authenticationSession.AccessToken, _userKey));
        public DetailsStore DetailsStore => _detailsStore ?? (_detailsStore = new DetailsStore(_authenticationSession.AccessToken, _userKey));
        public PayrollStore PayrollStore => _payrollStore ?? (_payrollStore = new PayrollStore(_authenticationSession.AccessToken, _userKey));
        public CostCenterStore CostCenterStore => _costCenterStore ?? (_costCenterStore = new CostCenterStore(_authenticationSession.AccessToken, _userKey));
        public FinancialYearStore FinancialYearStore => _financialYearStore ?? (_financialYearStore = new FinancialYearStore(_authenticationSession.AccessToken, _userKey));
        public MetaStore MetaStore => _metaStore ?? (_metaStore = new MetaStore(_authenticationSession.AccessToken, _userKey));
        
        public ClientSession(AuthenticationSession authenticationSession, string clientPublicKey)
        {
            _authenticationSession = authenticationSession;
            _userKey = clientPublicKey;
        }
    }
}