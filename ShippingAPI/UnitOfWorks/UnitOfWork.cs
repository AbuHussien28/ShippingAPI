using ShippingAPI.Data;
using ShippingAPI.Repositories;

namespace ShippingAPI.UnitOfWorks
{
    public class UnitOfWork
    {
        ShippingContext context;

        public AccountTransactionRepo accountTransactionRepo;
        public BankRepo bankRepo;
        public BranchRepo branchRepo;
        public CityRepo cityRepo;
        public CommissionSettingRepo commissionSettingRepo;
        public CustomPriceRepo customPriceRepo;
        public ExtraVillagePriceRepo extraVillagePriceRepo;
        public FinancialTransferRepo financialTransferRepo;
        public GovernateRepo governateRepo;
        public OrderRejectionRepo orderRejectionRepo;
        public OrderRepo orderRepo;
        public PermissionRepo permissionRepo;
        public SafeRepo safeRepo;
        public ShippingTypeRepo shippingTypeRepo;
        public UserGroupPermissionRepo userGroupPermissionRepo;
        public UserGroupRepo userGroupRepo;
        public WeightRepo weightRepo;

        public UnitOfWork(ShippingContext context) {
            this.context = context;
        }

        //public StudentRepo StudentRepo
        //{
        //    get
        //    {
        //        if (studentRepo == null)
        //            studentRepo = new StudentRepo(context);
        //        return studentRepo;
        //    }
        //}
        public AccountTransactionRepo AccountTransactionRepo
        {
            get
            {
                if (accountTransactionRepo == null)
                    accountTransactionRepo = new AccountTransactionRepo(context);
                return accountTransactionRepo;
                
            }
        }

        public BankRepo BankRepo
        {
            get
            {
                if (bankRepo == null)
                    bankRepo = new BankRepo(context);
                return bankRepo;

            }
        }

        public BranchRepo BranchRepo
        {
            get
            {
                if (branchRepo == null)
                    branchRepo = new BranchRepo(context);
                return branchRepo;
            }
        }

        public CityRepo CityRepo
        {
            get
            {
                if (cityRepo == null)
                    cityRepo = new CityRepo(context);
                return cityRepo;
            }
        }

        public CommissionSettingRepo CommissionSettingRepo
        {
            get
            {
                if (commissionSettingRepo == null)
                    commissionSettingRepo = new CommissionSettingRepo(context);
                return commissionSettingRepo;
            }
        }

        public CustomPriceRepo CustomPriceRepo
        {
            get
            {
                if (customPriceRepo == null)
                    customPriceRepo = new CustomPriceRepo(context);
                return customPriceRepo;
            }
        }

        public ExtraVillagePriceRepo ExtraVillagePriceRepo
        {
            get
            {
                if (extraVillagePriceRepo == null)
                    extraVillagePriceRepo = new ExtraVillagePriceRepo(context);
                return extraVillagePriceRepo;
            }
        }

        public FinancialTransferRepo FinancialTransferRepo
        {
            get
            {
                if (financialTransferRepo == null)
                    financialTransferRepo = new FinancialTransferRepo(context);
                return financialTransferRepo;
            }
        }

        public GovernateRepo GovernateRepo
        {
            get
            {
                if (governateRepo == null)
                    governateRepo = new GovernateRepo(context);
                return governateRepo;
            }
        }

        public OrderRejectionRepo OrderRejectionRepo
        {
            get
            {
                if (orderRejectionRepo == null)
                    orderRejectionRepo = new OrderRejectionRepo(context);
                return orderRejectionRepo;
            }
        }

        public OrderRepo OrderRepo
        {
            get
            {
                if (orderRepo == null)
                    orderRepo = new OrderRepo(context);
                return orderRepo;
            }
        }

        public PermissionRepo PermissionRepo
        {
            get
            {
                if (permissionRepo == null)
                    permissionRepo = new PermissionRepo(context);
                return permissionRepo;
            }
        }

        public SafeRepo SafeRepo
        {
            get
            {
                if (safeRepo == null)
                    safeRepo = new SafeRepo(context);
                return safeRepo;
            }
        }

        public ShippingTypeRepo ShippingTypeRepo
        {
            get
            {
                if (shippingTypeRepo == null)
                    shippingTypeRepo = new ShippingTypeRepo(context);
                return shippingTypeRepo;
            }
        }

        public UserGroupPermissionRepo UserGroupPermissionRepo
        {
            get
            {
                if (userGroupPermissionRepo == null)
                    userGroupPermissionRepo = new UserGroupPermissionRepo(context);
                return userGroupPermissionRepo;
            }
        }

        public UserGroupRepo UserGroupRepo
        {
            get
            {
                if (userGroupRepo == null)
                    userGroupRepo = new UserGroupRepo(context);
                return userGroupRepo;
            }
        }

        public WeightRepo WeightRepo
        {
            get
            {
                if (weightRepo == null)
                    weightRepo = new WeightRepo(context);
                return weightRepo;
            }
        }

        public void save()
        {
            context.SaveChanges();
        }




    }
}
