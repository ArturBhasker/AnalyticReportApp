using Microsoft.EntityFrameworkCore;

namespace AnalyticReportApp.Infrastructure.DbContexts
{
    internal partial class C1NWindContext : DbContext
    {
        public C1NWindContext()
        {
        }

        public C1NWindContext(DbContextOptions<C1NWindContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointee> Appointees { get; set; } = null!;
        public virtual DbSet<Appointment> Appointments { get; set; } = null!;
        public virtual DbSet<AppointmentsFull> AppointmentsFulls { get; set; } = null!;
        public virtual DbSet<AppointmentsMulti> AppointmentsMultis { get; set; } = null!;
        public virtual DbSet<AtbillReport> AtbillReports { get; set; } = null!;
        public virtual DbSet<BloodReportPatientInfo> BloodReportPatientInfos { get; set; } = null!;
        public virtual DbSet<BloodReportResult> BloodReportResults { get; set; } = null!;
        public virtual DbSet<Calendar> Calendars { get; set; } = null!;
        public virtual DbSet<CallList> CallLists { get; set; } = null!;
        public virtual DbSet<Car> Cars { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<Chart3Ddatum> Chart3Ddata { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Composer> Composers { get; set; } = null!;
        public virtual DbSet<Contact> Contacts { get; set; } = null!;
        public virtual DbSet<CustType> CustTypes { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<Customer1> Customers1 { get; set; } = null!;
        public virtual DbSet<CustomerDemo> CustomerDemos { get; set; } = null!;
        public virtual DbSet<CustomersMap> CustomersMaps { get; set; } = null!;
        public virtual DbSet<CustomersMulti> CustomersMultis { get; set; } = null!;
        public virtual DbSet<Datum> Data { get; set; } = null!;
        public virtual DbSet<Delivery> Deliveries { get; set; } = null!;
        public virtual DbSet<DeliveryResult> DeliveryResults { get; set; } = null!;
        public virtual DbSet<Detail> Details { get; set; } = null!;
        public virtual DbSet<DoughtNutChartDatum> DoughtNutChartData { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<EmployeeTerritory> EmployeeTerritories { get; set; } = null!;
        public virtual DbSet<EmployeeTravelExp> EmployeeTravelExps { get; set; } = null!;
        public virtual DbSet<GanttChartDatum> GanttChartData { get; set; } = null!;
        public virtual DbSet<Instructor> Instructors { get; set; } = null!;
        public virtual DbSet<InventoryManagement> InventoryManagements { get; set; } = null!;
        public virtual DbSet<Label> Labels { get; set; } = null!;
        public virtual DbSet<MarketingProjectPlanDatum> MarketingProjectPlanData { get; set; } = null!;
        public virtual DbSet<MonthlyBudget> MonthlyBudgets { get; set; } = null!;
        public virtual DbSet<MonthlyProjectCostTracking> MonthlyProjectCostTrackings { get; set; } = null!;
        public virtual DbSet<Opu> Opus { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<Order1> Orders1 { get; set; } = null!;
        public virtual DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public virtual DbSet<PatientInfo> PatientInfos { get; set; } = null!;
        public virtual DbSet<PatientTestResult> PatientTestResults { get; set; } = null!;
        public virtual DbSet<Photo> Photos { get; set; } = null!;
        public virtual DbSet<PolarSample> PolarSamples { get; set; } = null!;
        public virtual DbSet<PriceComparison> PriceComparisons { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductsSchedule> ProductsSchedules { get; set; } = null!;
        public virtual DbSet<Property> Properties { get; set; } = null!;
        public virtual DbSet<Region> Regions { get; set; } = null!;
        public virtual DbSet<Resource> Resources { get; set; } = null!;
        public virtual DbSet<SalesByQuarter> SalesByQuarters { get; set; } = null!;
        public virtual DbSet<ScatterPoint> ScatterPoints { get; set; } = null!;
        public virtual DbSet<Shipper> Shippers { get; set; } = null!;
        public virtual DbSet<StateNamesGeo> StateNamesGeos { get; set; } = null!;
        public virtual DbSet<Status> Statuses { get; set; } = null!;
        public virtual DbSet<StockChartDatum> StockChartData { get; set; } = null!;
        public virtual DbSet<Supplier> Suppliers { get; set; } = null!;
        public virtual DbSet<SystemAdaptability> SystemAdaptabilities { get; set; } = null!;
        public virtual DbSet<Task> Tasks { get; set; } = null!;
        public virtual DbSet<TaskList> TaskLists { get; set; } = null!;
        public virtual DbSet<TelephoneBill> TelephoneBills { get; set; } = null!;
        public virtual DbSet<Territory> Territories { get; set; } = null!;
        public virtual DbSet<TimeTable> TimeTables { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("DataSource=.\\C1NWind.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointee>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.HireDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.End).HasColumnType("datetime");

                entity.Property(e => e.Start).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppointmentsFull>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Appointments_Full");

                entity.Property(e => e.End).HasColumnType("datetime");

                entity.Property(e => e.Start).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppointmentsMulti>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Appointments_Multi");

                entity.Property(e => e.End).HasColumnType("datetime");

                entity.Property(e => e.Start).HasColumnType("datetime");
            });

            modelBuilder.Entity<AtbillReport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ATBillReport");

                entity.Property(e => e.AccNo).HasColumnName("AccNO");

                entity.Property(e => e.BillingDate).HasColumnType("datetime");

                entity.Property(e => e.BillingId).HasColumnName("BillingID");

                entity.Property(e => e.CurrentCharges).HasColumnType("NUMERIC");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.PreviousBill).HasColumnType("NUMERIC");

                entity.Property(e => e.Tvcharge)
                    .HasColumnType("NUMERIC")
                    .HasColumnName("TVCharge");

                entity.Property(e => e.VoiceCharge).HasColumnType("NUMERIC");

                entity.Property(e => e.WireLessCharge).HasColumnType("NUMERIC");
            });

            modelBuilder.Entity<BloodReportPatientInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BloodReport_PatientInfo");

                entity.Property(e => e.DateCollected).HasColumnType("datetime");

                entity.Property(e => e.DateEntered).HasColumnType("datetime");

                entity.Property(e => e.DateReported).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.PatientFname).HasColumnName("PatientFName");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.PatientLname).HasColumnName("PatientLName");

                entity.Property(e => e.PatientMname).HasColumnName("PatientMName");
            });

            modelBuilder.Entity<BloodReportResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BloodReport_Result");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");
            });

            modelBuilder.Entity<Calendar>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CalendarId).HasColumnName("CalendarID");
            });

            modelBuilder.Entity<CallList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CallList");

                entity.Property(e => e.CallDate).HasColumnType("datetime");

                entity.Property(e => e.Phone).HasColumnType("NUMERIC");
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Hp).HasColumnName("HP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Liter).HasColumnType("NUMERIC");

                entity.Property(e => e.MpgCity).HasColumnName("MPG_City");

                entity.Property(e => e.MpgHighway).HasColumnName("MPG_Highway");

                entity.Property(e => e.Price).HasColumnType("NUMERIC");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            });

            modelBuilder.Entity<Chart3Ddatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Chart3DData");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.City1).HasColumnName("City");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Composer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Composer");

                entity.Property(e => e.Birth).HasColumnType("datetime");

                entity.Property(e => e.Death).HasColumnType("datetime");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Callback).HasColumnType("bit");

                entity.Property(e => e.ContactDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CustType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CustType");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer");

                entity.Property(e => e.Contacted).HasColumnType("datetime");

                entity.Property(e => e.Phone).HasColumnType("NUMERIC");
            });

            modelBuilder.Entity<Customer1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customers");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            });

            modelBuilder.Entity<CustomerDemo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customer_demo");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<CustomersMap>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customers_Map");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Latitude).HasColumnType("NUMERIC");

                entity.Property(e => e.Longitude).HasColumnType("NUMERIC");
            });

            modelBuilder.Entity<CustomersMulti>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Customers_Multi");
            });

            modelBuilder.Entity<Datum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Cost).HasColumnType("NUMERIC");

                entity.Property(e => e.Id).HasColumnType("NUMERIC");

                entity.Property(e => e.Qt).HasColumnType("NUMERIC");

                entity.Property(e => e.Sum).HasColumnType("NUMERIC");
            });

            modelBuilder.Entity<Delivery>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Delivery");
            });

            modelBuilder.Entity<DeliveryResult>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Detail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Detail");

                entity.Property(e => e.DealerCost).HasColumnType("NUMERIC");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.Msrp)
                    .HasColumnType("NUMERIC")
                    .HasColumnName("MSRP");
            });

            modelBuilder.Entity<DoughtNutChartDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.HireDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EmployeeTerritory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");
            });

            modelBuilder.Entity<EmployeeTravelExp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EmployeeTravelExp");

                entity.Property(e => e.AutherisedBy).HasColumnName("AutherisedBY");

                entity.Property(e => e.ConferencesSeminars).HasColumnName("Conferences_seminars");

                entity.Property(e => e.CurrExchangeRate).HasColumnName("Curr_Exchange_rate");

                entity.Property(e => e.DateFrom)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_From");

                entity.Property(e => e.DateTo)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_To");

                entity.Property(e => e.DateofSubmission).HasColumnType("datetime");

                entity.Property(e => e.DescOfExp).HasColumnName("Desc_of_Exp");

                entity.Property(e => e.ExpId).HasColumnName("Exp_ID");

                entity.Property(e => e.ExpenceCurr).HasColumnName("Expence_Curr");

                entity.Property(e => e.GroundTransportation).HasColumnName("Ground_transportation");

                entity.Property(e => e.Lodging).HasColumnName("lodging");

                entity.Property(e => e.MealsTips).HasColumnName("Meals_Tips");

                entity.Property(e => e.MileageReimbursement).HasColumnName("Mileage_Reimbursement");
            });

            modelBuilder.Entity<GanttChartDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<InventoryManagement>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("InventoryManagement");

                entity.Property(e => e.CustomerName).HasColumnName("Customer_Name");

                entity.Property(e => e.ItemCategory).HasColumnName("Item_Category");

                entity.Property(e => e.ItemName).HasColumnName("Item_Name");

                entity.Property(e => e.QtySold).HasColumnName("Qty_Sold");

                entity.Property(e => e.SalesId).HasColumnName("Sales_ID");

                entity.Property(e => e.SoldDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Sold_Date");
            });

            modelBuilder.Entity<Label>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<MarketingProjectPlanDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ActualCost).HasColumnName("Actual_Cost");

                entity.Property(e => e.ActualEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Actual_EndDate");

                entity.Property(e => e.ActualStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Actual_StartDate");

                entity.Property(e => e.AnticipatedEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Anticipated_EndDate");

                entity.Property(e => e.AnticipatedStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Anticipated_StartDate");

                entity.Property(e => e.AssignTo).HasColumnName("AssignTO");

                entity.Property(e => e.EstimatedCost).HasColumnName("Estimated_Cost");

                entity.Property(e => e.TaskId).HasColumnName("Task_ID");

                entity.Property(e => e.TaskName).HasColumnName("Task_Name");

                entity.Property(e => e.TaskOwner).HasColumnName("Task_Owner");

                entity.Property(e => e.TaskStatus).HasColumnName("Task_Status");
            });

            modelBuilder.Entity<MonthlyBudget>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MonthlyBudget");

                entity.Property(e => e.ActualValue).HasColumnName("Actual_Value");

                entity.Property(e => e.EstimatedValue).HasColumnName("Estimated_Value");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TranMainType).HasColumnName("Tran_MainType");

                entity.Property(e => e.TranName).HasColumnName("Tran_Name");

                entity.Property(e => e.TranType).HasColumnName("Tran_Type");
            });

            modelBuilder.Entity<MonthlyProjectCostTracking>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MonthlyProjectCostTracking");

                entity.Property(e => e.ExpenseId).HasColumnName("ExpenseID");

                entity.Property(e => e.OperationRate).HasColumnType("money");
            });

            modelBuilder.Entity<Opu>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Order");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PaymentAmount).HasColumnType("NUMERIC");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.PurchaseDate).HasColumnType("datetime");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<Order1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Orders");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Freight).HasColumnType("NUMERIC");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.RequiredDate).HasColumnType("datetime");

                entity.Property(e => e.ShippedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<OrderDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Order Details");

                entity.Property(e => e.Discount).HasColumnType("NUMERIC");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.UnitPrice).HasColumnType("NUMERIC");
            });

            modelBuilder.Entity<PatientInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PatientInfo");

                entity.Property(e => e.DateCollected).HasColumnType("datetime");

                entity.Property(e => e.DateReceived).HasColumnType("datetime");

                entity.Property(e => e.DateReported).HasColumnType("datetime");

                entity.Property(e => e.DateRun).HasColumnType("datetime");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");
            });

            modelBuilder.Entity<PatientTestResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PatientTestResult");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.RowId).HasColumnName("Row_ID");
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Photo1).HasColumnName("Photo");

                entity.Property(e => e.PhotoId).HasColumnName("PhotoID");
            });

            modelBuilder.Entity<PolarSample>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PolarSample");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<PriceComparison>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PriceComparison");

                entity.Property(e => e.Price2013).HasColumnName("Price_2013");

                entity.Property(e => e.Price2014).HasColumnName("Price_2014");

                entity.Property(e => e.ProductId).HasColumnName("Product_ID");

                entity.Property(e => e.ProductName).HasColumnName("Product_Name");

                entity.Property(e => e.ProductType).HasColumnName("Product_Type");

                entity.Property(e => e.ProductTypePhoto)
                    .HasColumnType("image")
                    .HasColumnName("Product_Type_Photo");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.UnitPrice).HasColumnType("NUMERIC");
            });

            modelBuilder.Entity<ProductsSchedule>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Products_Schedule");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.UnitPrice).HasColumnType("NUMERIC");
            });

            modelBuilder.Entity<Property>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Region");

                entity.Property(e => e.RegionId).HasColumnName("RegionID");
            });

            modelBuilder.Entity<Resource>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Cost).HasColumnType("NUMERIC");

                entity.Property(e => e.ResourceId).HasColumnName("ResourceID");
            });

            modelBuilder.Entity<SalesByQuarter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SalesByQuarter");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProductX).HasColumnType("NUMERIC");

                entity.Property(e => e.ProductY).HasColumnType("NUMERIC");

                entity.Property(e => e.ProductZ).HasColumnType("NUMERIC");
            });

            modelBuilder.Entity<ScatterPoint>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Y1).HasColumnName("y1");

                entity.Property(e => e.Y2).HasColumnName("y2");

                entity.Property(e => e.Y3).HasColumnName("y3");
            });

            modelBuilder.Entity<Shipper>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ShipperId).HasColumnName("ShipperID");
            });

            modelBuilder.Entity<StateNamesGeo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("StateNamesGeo");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Latitude).HasColumnType("NUMERIC");

                entity.Property(e => e.Longitude).HasColumnType("NUMERIC");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasNoKey();
            });

            modelBuilder.Entity<StockChartDatum>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AdjClose).HasColumnType("NUMERIC");

                entity.Property(e => e.Close).HasColumnType("NUMERIC");

                entity.Property(e => e.High).HasColumnType("NUMERIC");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Low).HasColumnType("NUMERIC");

                entity.Property(e => e.Volumn).HasColumnType("NUMERIC");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");
            });

            modelBuilder.Entity<SystemAdaptability>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SystemAdaptability");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MobileWalk).HasColumnType("Numeric");

                entity.Property(e => e.NewTransport).HasColumnType("Numeric");

                entity.Property(e => e.Otis)
                    .HasColumnType("real")
                    .HasColumnName("OTIS");
            });

            modelBuilder.Entity<Task>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CalendarId).HasColumnName("CalendarID");

                entity.Property(e => e.ConstraintDate).HasColumnType("datetime");

                entity.Property(e => e.Deadline).HasColumnType("datetime");

                entity.Property(e => e.Finish).HasColumnType("datetime");

                entity.Property(e => e.HideBar).HasColumnType("bit");

                entity.Property(e => e.Initialized).HasColumnType("bit");

                entity.Property(e => e.NextId).HasColumnName("NextID");

                entity.Property(e => e.OutlineParentId).HasColumnName("OutlineParentID");

                entity.Property(e => e.Start).HasColumnType("datetime");

                entity.Property(e => e.Summary).HasColumnType("bit");

                entity.Property(e => e.TaskId).HasColumnName("TaskID");
            });

            modelBuilder.Entity<TaskList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TaskList");

                entity.Property(e => e.Done).HasColumnType("bit");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Target).HasColumnType("datetime");
            });

            modelBuilder.Entity<TelephoneBill>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TelephoneBill");

                entity.Property(e => e.AccNo).HasColumnName("AccNO");

                entity.Property(e => e.BillingDate).HasColumnType("datetime");

                entity.Property(e => e.BillingId).HasColumnName("BillingID");

                entity.Property(e => e.CurrentCharges).HasColumnType("NUMERIC");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.PreviousBill).HasColumnType("NUMERIC");

                entity.Property(e => e.Tvcharge)
                    .HasColumnType("NUMERIC")
                    .HasColumnName("TVCharge");

                entity.Property(e => e.VoiceCharge).HasColumnType("NUMERIC");

                entity.Property(e => e.WireLessCharge).HasColumnType("NUMERIC");
            });

            modelBuilder.Entity<Territory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.RegionId).HasColumnName("RegionID");

                entity.Property(e => e.TerritoryId).HasColumnName("TerritoryID");
            });

            modelBuilder.Entity<TimeTable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TimeTable");

                entity.Property(e => e.Begin).HasColumnType("datetime");

                entity.Property(e => e.End).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
