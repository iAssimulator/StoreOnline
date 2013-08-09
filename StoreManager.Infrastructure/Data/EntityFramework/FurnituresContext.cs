using System.Data.Entity;
using StoreOnline.Core.Models;
using StoreOnline.Infrastructure.Data.EntityFramework.Mapping;
//using StoreOnline.Infrastructure.Models.Mapping;

namespace StoreOnline.Infrastructure.Data.EntityFramework
{
    public partial class FurnituresContext : DbContext
    {
        static FurnituresContext()
        {
            Database.SetInitializer<FurnituresContext>(null);
        }

        public FurnituresContext()
            : base("Name=FurnituresContext")
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<County> Counties { get; set; }
        public DbSet<MemberRole> MemberRoles { get; set; }
        public DbSet<MemberUser> MemberUsers { get; set; }
        //public DbSet<Feature> Features { get; set; }
        //public DbSet<Gazetteer> Gazetteers { get; set; }
        //public DbSet<OSCounty> OSCounties { get; set; }
        //public DbSet<PostCodeData> PostCodeDatas { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<AddressType> AddressTypes { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductPhoto> ProductPhotoes { get; set; }
        public DbSet<ProductProductPhoto> ProductProductPhotoes { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }
        public DbSet<OrderState> OrderStates { get; set; }
        public DbSet<ShipMethod> ShipMethods { get; set; }
        public DbSet<ContactCreditCard> ContactCreditCards { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<CreditCardType> CreditCardTypes { get; set; }
        public DbSet<Currency> Currencies { get; set; }
        public DbSet<CurrencyRate> CurrencyRates { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }
        public DbSet<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public DbSet<SalesPerson> SalesPersons { get; set; }
        public DbSet<SalesPersonQuotaHistory> SalesPersonQuotaHistories { get; set; }
        public DbSet<ShoppingBasketItem> ShoppingBasketItems { get; set; }
        public DbSet<SpecialOffer> SpecialOffers { get; set; }
        public DbSet<SpecialOfferProduct> SpecialOfferProducts { get; set; }
        public DbSet<SpecialOfferType> SpecialOfferTypes { get; set; }
        public DbSet<Craftman> Craftmen { get; set; }
        //public DbSet<Summary_of_Sales_by_Quarter> Summary_of_Sales_by_Quarters { get; set; }
        //public DbSet<Summary_of_Sales_by_Year> Summary_of_Sales_by_Years { get; set; }
        //public DbSet<VewOrderDetail> VewOrderDetails { get; set; }
        //public DbSet<ViewAlsoPurchased> ViewAlsoPurchaseds { get; set; }
        //public DbSet<ViewCart> ViewCarts { get; set; }
        //public DbSet<ViewInvoice> ViewInvoices { get; set; }
        //public DbSet<ViewShowcase> ViewShowcases { get; set; }
        public DbSet<vEmployee> vEmployees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new CountryMap());
            modelBuilder.Configurations.Add(new CountyMap());
            modelBuilder.Configurations.Add(new MemberRoleMap());
            modelBuilder.Configurations.Add(new MemberUserMap());
            //modelBuilder.Configurations.Add(new FeatureMap());
            //modelBuilder.Configurations.Add(new GazetteerMap());
            //modelBuilder.Configurations.Add(new OSCountyMap());
            //modelBuilder.Configurations.Add(new PostCodeDataMap());
            modelBuilder.Configurations.Add(new AddressMap());
            modelBuilder.Configurations.Add(new AddressTypeMap());
            modelBuilder.Configurations.Add(new ContactMap());
            modelBuilder.Configurations.Add(new ContactTypeMap());
            modelBuilder.Configurations.Add(new PhotoMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new ProductCategoryMap());
            modelBuilder.Configurations.Add(new ProductPhotoMap());
            modelBuilder.Configurations.Add(new ProductProductPhotoMap());
            modelBuilder.Configurations.Add(new ProductReviewMap());
            modelBuilder.Configurations.Add(new OrderStateMap());
            modelBuilder.Configurations.Add(new ShipMethodMap());
            modelBuilder.Configurations.Add(new ContactCreditCardMap());
            modelBuilder.Configurations.Add(new CreditCardMap());
            modelBuilder.Configurations.Add(new CreditCardTypeMap());
            modelBuilder.Configurations.Add(new CurrencyMap());
            modelBuilder.Configurations.Add(new CurrencyRateMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new SalesOrderDetailMap());
            modelBuilder.Configurations.Add(new SalesOrderHeaderMap());
            modelBuilder.Configurations.Add(new SalesPersonMap());
            modelBuilder.Configurations.Add(new SalesPersonQuotaHistoryMap());
            modelBuilder.Configurations.Add(new ShoppingBasketItemMap());
            modelBuilder.Configurations.Add(new SpecialOfferMap());
            modelBuilder.Configurations.Add(new SpecialOfferProductMap());
            modelBuilder.Configurations.Add(new SpecialOfferTypeMap());
            modelBuilder.Configurations.Add(new CraftmanMap());
            //modelBuilder.Configurations.Add(new Summary_of_Sales_by_QuarterMap());
            //modelBuilder.Configurations.Add(new Summary_of_Sales_by_YearMap());
            //modelBuilder.Configurations.Add(new VewOrderDetailMap());
            //modelBuilder.Configurations.Add(new ViewAlsoPurchasedMap());
            //modelBuilder.Configurations.Add(new ViewCartMap());
            //modelBuilder.Configurations.Add(new ViewInvoiceMap());
            //modelBuilder.Configurations.Add(new ViewShowcaseMap());
            modelBuilder.Configurations.Add(new vEmployeeMap());
        }
    }
}
