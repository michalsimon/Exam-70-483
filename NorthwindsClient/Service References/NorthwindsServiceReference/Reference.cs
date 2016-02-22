//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 09.02.2016 21:07:07
namespace NorthwindsClient.NorthwindsServiceReference
{
    
    /// <summary>
    /// There are no comments for NorthwndEntities in the schema.
    /// </summary>
    public partial class NorthwndEntities : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new NorthwndEntities object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public NorthwndEntities(global::System.Uri serviceRoot) : 
                base(serviceRoot, global::System.Data.Services.Common.DataServiceProtocolVersion.V3)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
            this.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            global::System.Type resolvedType = this.DefaultResolveType(typeName, "NorthwindsModel", "NorthwindsClient.NorthwindsServiceReference");
            if ((resolvedType != null))
            {
                return resolvedType;
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("NorthwindsClient.NorthwindsServiceReference", global::System.StringComparison.Ordinal))
            {
                return string.Concat("NorthwindsModel.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for Categories in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Categories> Categories
        {
            get
            {
                if ((this._Categories == null))
                {
                    this._Categories = base.CreateQuery<Categories>("Categories");
                }
                return this._Categories;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Categories> _Categories;
        /// <summary>
        /// There are no comments for Categories in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToCategories(Categories categories)
        {
            base.AddObject("Categories", categories);
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private abstract class GeneratedEdmModel
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::Microsoft.Data.Edm.IEdmModel ParsedModel = LoadModelFromString();
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private const string ModelPart0 = @"<edmx:Edmx Version=""1.0"" xmlns:edmx=""http://schemas.microsoft.com/ado/2007/06/edmx""><edmx:DataServices m:DataServiceVersion=""1.0"" m:MaxDataServiceVersion=""3.0"" xmlns:m=""http://schemas.microsoft.com/ado/2007/08/dataservices/metadata""><Schema Namespace=""NorthwindsModel"" xmlns=""http://schemas.microsoft.com/ado/2009/11/edm""><EntityType Name=""Categories""><Key><PropertyRef Name=""CategoryID"" /></Key><Property Name=""CategoryID"" Type=""Edm.Int32"" Nullable=""false"" p6:StoreGeneratedPattern=""Identity"" xmlns:p6=""http://schemas.microsoft.com/ado/2009/02/edm/annotation"" /><Property Name=""CategoryName"" Type=""Edm.String"" Nullable=""false"" MaxLength=""15"" FixedLength=""false"" Unicode=""true"" /><Property Name=""Description"" Type=""Edm.String"" MaxLength=""Max"" FixedLength=""false"" Unicode=""true"" /><Property Name=""Picture"" Type=""Edm.Binary"" MaxLength=""Max"" FixedLength=""false"" /></EntityType></Schema><Schema Namespace=""NorthwindsWCFDataService"" xmlns=""http://schemas.microsoft.com/ado/2009/11/edm""><EntityContainer Name=""NorthwndEntities"" m:IsDefaultEntityContainer=""true"" p6:LazyLoadingEnabled=""true"" xmlns:p6=""http://schemas.microsoft.com/ado/2009/02/edm/annotation""><EntitySet Name=""Categories"" EntityType=""NorthwindsModel.Categories"" /></EntityContainer></Schema></edmx:DataServices></edmx:Edmx>";
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static string GetConcatenatedEdmxString()
            {
                return string.Concat(ModelPart0);
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            public static global::Microsoft.Data.Edm.IEdmModel GetInstance()
            {
                return ParsedModel;
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::Microsoft.Data.Edm.IEdmModel LoadModelFromString()
            {
                string edmxToParse = GetConcatenatedEdmxString();
                global::System.Xml.XmlReader reader = CreateXmlReader(edmxToParse);
                try
                {
                    return global::Microsoft.Data.Edm.Csdl.EdmxReader.Parse(reader);
                }
                finally
                {
                    ((global::System.IDisposable)(reader)).Dispose();
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
            private static global::System.Xml.XmlReader CreateXmlReader(string edmxToParse)
            {
                return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(edmxToParse));
            }
        }
    }
    /// <summary>
    /// There are no comments for NorthwindsModel.Categories in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CategoryID
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Categories")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("CategoryID")]
    public partial class Categories : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Create a new Categories object.
        /// </summary>
        /// <param name="categoryID">Initial value of CategoryID.</param>
        /// <param name="categoryName">Initial value of CategoryName.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Categories CreateCategories(int categoryID, string categoryName)
        {
            Categories categories = new Categories();
            categories.CategoryID = categoryID;
            categories.CategoryName = categoryName;
            return categories;
        }
        /// <summary>
        /// There are no comments for Property CategoryID in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int CategoryID
        {
            get
            {
                return this._CategoryID;
            }
            set
            {
                this.OnCategoryIDChanging(value);
                this._CategoryID = value;
                this.OnCategoryIDChanged();
                this.OnPropertyChanged("CategoryID");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _CategoryID;
        partial void OnCategoryIDChanging(int value);
        partial void OnCategoryIDChanged();
        /// <summary>
        /// There are no comments for Property CategoryName in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string CategoryName
        {
            get
            {
                return this._CategoryName;
            }
            set
            {
                this.OnCategoryNameChanging(value);
                this._CategoryName = value;
                this.OnCategoryNameChanged();
                this.OnPropertyChanged("CategoryName");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _CategoryName;
        partial void OnCategoryNameChanging(string value);
        partial void OnCategoryNameChanged();
        /// <summary>
        /// There are no comments for Property Description in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// There are no comments for Property Picture in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public byte[] Picture
        {
            get
            {
                if ((this._Picture != null))
                {
                    return ((byte[])(this._Picture.Clone()));
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OnPictureChanging(value);
                this._Picture = value;
                this.OnPictureChanged();
                this.OnPropertyChanged("Picture");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private byte[] _Picture;
        partial void OnPictureChanging(byte[] value);
        partial void OnPictureChanged();
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}