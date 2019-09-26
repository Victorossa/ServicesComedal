//------------------------------------------------------------------------------
// <generado automáticamente>
//     Este código fue generado por una herramienta.
//     //
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </generado automáticamente>
//------------------------------------------------------------------------------

namespace ServicioVictor
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="tContinent", Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class tContinent : object
    {
        
        private string sCodeField;
        
        private string sNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string sCode
        {
            get
            {
                return this.sCodeField;
            }
            set
            {
                this.sCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string sName
        {
            get
            {
                return this.sNameField;
            }
            set
            {
                this.sNameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="tCurrency", Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class tCurrency : object
    {
        
        private string sISOCodeField;
        
        private string sNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string sISOCode
        {
            get
            {
                return this.sISOCodeField;
            }
            set
            {
                this.sISOCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string sName
        {
            get
            {
                return this.sNameField;
            }
            set
            {
                this.sNameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="tCountryCodeAndName", Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class tCountryCodeAndName : object
    {
        
        private string sISOCodeField;
        
        private string sNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string sISOCode
        {
            get
            {
                return this.sISOCodeField;
            }
            set
            {
                this.sISOCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string sName
        {
            get
            {
                return this.sNameField;
            }
            set
            {
                this.sNameField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="tCountryCodeAndNameGroupedByContinent", Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class tCountryCodeAndNameGroupedByContinent : object
    {
        
        private ServicioVictor.tContinent ContinentField;
        
        private ServicioVictor.tCountryCodeAndName[] CountryCodeAndNamesField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public ServicioVictor.tContinent Continent
        {
            get
            {
                return this.ContinentField;
            }
            set
            {
                this.ContinentField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public ServicioVictor.tCountryCodeAndName[] CountryCodeAndNames
        {
            get
            {
                return this.CountryCodeAndNamesField;
            }
            set
            {
                this.CountryCodeAndNamesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="tCountryInfo", Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class tCountryInfo : object
    {
        
        private string sISOCodeField;
        
        private string sNameField;
        
        private string sCapitalCityField;
        
        private string sPhoneCodeField;
        
        private string sContinentCodeField;
        
        private string sCurrencyISOCodeField;
        
        private string sCountryFlagField;
        
        private ServicioVictor.tLanguage[] LanguagesField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string sISOCode
        {
            get
            {
                return this.sISOCodeField;
            }
            set
            {
                this.sISOCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string sName
        {
            get
            {
                return this.sNameField;
            }
            set
            {
                this.sNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false, Order=2)]
        public string sCapitalCity
        {
            get
            {
                return this.sCapitalCityField;
            }
            set
            {
                this.sCapitalCityField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false, Order=3)]
        public string sPhoneCode
        {
            get
            {
                return this.sPhoneCodeField;
            }
            set
            {
                this.sPhoneCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false, Order=4)]
        public string sContinentCode
        {
            get
            {
                return this.sContinentCodeField;
            }
            set
            {
                this.sContinentCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false, Order=5)]
        public string sCurrencyISOCode
        {
            get
            {
                return this.sCurrencyISOCodeField;
            }
            set
            {
                this.sCurrencyISOCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false, Order=6)]
        public string sCountryFlag
        {
            get
            {
                return this.sCountryFlagField;
            }
            set
            {
                this.sCountryFlagField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false, Order=7)]
        public ServicioVictor.tLanguage[] Languages
        {
            get
            {
                return this.LanguagesField;
            }
            set
            {
                this.LanguagesField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Name="tLanguage", Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class tLanguage : object
    {
        
        private string sISOCodeField;
        
        private string sNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string sISOCode
        {
            get
            {
                return this.sISOCodeField;
            }
            set
            {
                this.sISOCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public string sName
        {
            get
            {
                return this.sNameField;
            }
            set
            {
                this.sNameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo", ConfigurationName="ServicioVictor.CountryInfoServiceSoapType")]
    public interface CountryInfoServiceSoapType
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioVictor.ListOfContinentsByNameResponse> ListOfContinentsByNameAsync(ServicioVictor.ListOfContinentsByNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioVictor.ListOfContinentsByCodeResponse> ListOfContinentsByCodeAsync(ServicioVictor.ListOfContinentsByCodeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioVictor.ListOfCurrenciesByNameResponse> ListOfCurrenciesByNameAsync(ServicioVictor.ListOfCurrenciesByNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioVictor.ListOfCurrenciesByCodeResponse> ListOfCurrenciesByCodeAsync(ServicioVictor.ListOfCurrenciesByCodeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioVictor.CurrencyNameResponse> CurrencyNameAsync(ServicioVictor.CurrencyNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioVictor.ListOfCountryNamesByCodeResponse> ListOfCountryNamesByCodeAsync(ServicioVictor.ListOfCountryNamesByCodeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioVictor.ListOfCountryNamesByNameResponse> ListOfCountryNamesByNameAsync(ServicioVictor.ListOfCountryNamesByNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioVictor.ListOfCountryNamesGroupedByContinentResponse> ListOfCountryNamesGroupedByContinentAsync(ServicioVictor.ListOfCountryNamesGroupedByContinentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioVictor.CountryNameResponse> CountryNameAsync(ServicioVictor.CountryNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioVictor.CountryISOCodeResponse> CountryISOCodeAsync(ServicioVictor.CountryISOCodeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioVictor.CapitalCityResponse> CapitalCityAsync(ServicioVictor.CapitalCityRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioVictor.CountryCurrencyResponse> CountryCurrencyAsync(ServicioVictor.CountryCurrencyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioVictor.CountryFlagResponse> CountryFlagAsync(ServicioVictor.CountryFlagRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioVictor.CountryIntPhoneCodeResponse> CountryIntPhoneCodeAsync(ServicioVictor.CountryIntPhoneCodeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioVictor.FullCountryInfoResponse> FullCountryInfoAsync(ServicioVictor.FullCountryInfoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioVictor.FullCountryInfoAllCountriesResponse> FullCountryInfoAllCountriesAsync(ServicioVictor.FullCountryInfoAllCountriesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioVictor.CountriesUsingCurrencyResponse> CountriesUsingCurrencyAsync(ServicioVictor.CountriesUsingCurrencyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioVictor.ListOfLanguagesByNameResponse> ListOfLanguagesByNameAsync(ServicioVictor.ListOfLanguagesByNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioVictor.ListOfLanguagesByCodeResponse> ListOfLanguagesByCodeAsync(ServicioVictor.ListOfLanguagesByCodeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioVictor.LanguageNameResponse> LanguageNameAsync(ServicioVictor.LanguageNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioVictor.LanguageISOCodeResponse> LanguageISOCodeAsync(ServicioVictor.LanguageISOCodeRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfContinentsByNameRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfContinentsByName", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.ListOfContinentsByNameRequestBody Body;
        
        public ListOfContinentsByNameRequest()
        {
        }
        
        public ListOfContinentsByNameRequest(ServicioVictor.ListOfContinentsByNameRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListOfContinentsByNameRequestBody
    {
        
        public ListOfContinentsByNameRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfContinentsByNameResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfContinentsByNameResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.ListOfContinentsByNameResponseBody Body;
        
        public ListOfContinentsByNameResponse()
        {
        }
        
        public ListOfContinentsByNameResponse(ServicioVictor.ListOfContinentsByNameResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class ListOfContinentsByNameResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServicioVictor.tContinent[] ListOfContinentsByNameResult;
        
        public ListOfContinentsByNameResponseBody()
        {
        }
        
        public ListOfContinentsByNameResponseBody(ServicioVictor.tContinent[] ListOfContinentsByNameResult)
        {
            this.ListOfContinentsByNameResult = ListOfContinentsByNameResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfContinentsByCodeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfContinentsByCode", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.ListOfContinentsByCodeRequestBody Body;
        
        public ListOfContinentsByCodeRequest()
        {
        }
        
        public ListOfContinentsByCodeRequest(ServicioVictor.ListOfContinentsByCodeRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListOfContinentsByCodeRequestBody
    {
        
        public ListOfContinentsByCodeRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfContinentsByCodeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfContinentsByCodeResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.ListOfContinentsByCodeResponseBody Body;
        
        public ListOfContinentsByCodeResponse()
        {
        }
        
        public ListOfContinentsByCodeResponse(ServicioVictor.ListOfContinentsByCodeResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class ListOfContinentsByCodeResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServicioVictor.tContinent[] ListOfContinentsByCodeResult;
        
        public ListOfContinentsByCodeResponseBody()
        {
        }
        
        public ListOfContinentsByCodeResponseBody(ServicioVictor.tContinent[] ListOfContinentsByCodeResult)
        {
            this.ListOfContinentsByCodeResult = ListOfContinentsByCodeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfCurrenciesByNameRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfCurrenciesByName", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.ListOfCurrenciesByNameRequestBody Body;
        
        public ListOfCurrenciesByNameRequest()
        {
        }
        
        public ListOfCurrenciesByNameRequest(ServicioVictor.ListOfCurrenciesByNameRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListOfCurrenciesByNameRequestBody
    {
        
        public ListOfCurrenciesByNameRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfCurrenciesByNameResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfCurrenciesByNameResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.ListOfCurrenciesByNameResponseBody Body;
        
        public ListOfCurrenciesByNameResponse()
        {
        }
        
        public ListOfCurrenciesByNameResponse(ServicioVictor.ListOfCurrenciesByNameResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class ListOfCurrenciesByNameResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServicioVictor.tCurrency[] ListOfCurrenciesByNameResult;
        
        public ListOfCurrenciesByNameResponseBody()
        {
        }
        
        public ListOfCurrenciesByNameResponseBody(ServicioVictor.tCurrency[] ListOfCurrenciesByNameResult)
        {
            this.ListOfCurrenciesByNameResult = ListOfCurrenciesByNameResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfCurrenciesByCodeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfCurrenciesByCode", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.ListOfCurrenciesByCodeRequestBody Body;
        
        public ListOfCurrenciesByCodeRequest()
        {
        }
        
        public ListOfCurrenciesByCodeRequest(ServicioVictor.ListOfCurrenciesByCodeRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListOfCurrenciesByCodeRequestBody
    {
        
        public ListOfCurrenciesByCodeRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfCurrenciesByCodeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfCurrenciesByCodeResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.ListOfCurrenciesByCodeResponseBody Body;
        
        public ListOfCurrenciesByCodeResponse()
        {
        }
        
        public ListOfCurrenciesByCodeResponse(ServicioVictor.ListOfCurrenciesByCodeResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class ListOfCurrenciesByCodeResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServicioVictor.tCurrency[] ListOfCurrenciesByCodeResult;
        
        public ListOfCurrenciesByCodeResponseBody()
        {
        }
        
        public ListOfCurrenciesByCodeResponseBody(ServicioVictor.tCurrency[] ListOfCurrenciesByCodeResult)
        {
            this.ListOfCurrenciesByCodeResult = ListOfCurrenciesByCodeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CurrencyNameRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CurrencyName", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.CurrencyNameRequestBody Body;
        
        public CurrencyNameRequest()
        {
        }
        
        public CurrencyNameRequest(ServicioVictor.CurrencyNameRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class CurrencyNameRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sCurrencyISOCode;
        
        public CurrencyNameRequestBody()
        {
        }
        
        public CurrencyNameRequestBody(string sCurrencyISOCode)
        {
            this.sCurrencyISOCode = sCurrencyISOCode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CurrencyNameResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CurrencyNameResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.CurrencyNameResponseBody Body;
        
        public CurrencyNameResponse()
        {
        }
        
        public CurrencyNameResponse(ServicioVictor.CurrencyNameResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class CurrencyNameResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CurrencyNameResult;
        
        public CurrencyNameResponseBody()
        {
        }
        
        public CurrencyNameResponseBody(string CurrencyNameResult)
        {
            this.CurrencyNameResult = CurrencyNameResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfCountryNamesByCodeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfCountryNamesByCode", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.ListOfCountryNamesByCodeRequestBody Body;
        
        public ListOfCountryNamesByCodeRequest()
        {
        }
        
        public ListOfCountryNamesByCodeRequest(ServicioVictor.ListOfCountryNamesByCodeRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListOfCountryNamesByCodeRequestBody
    {
        
        public ListOfCountryNamesByCodeRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfCountryNamesByCodeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfCountryNamesByCodeResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.ListOfCountryNamesByCodeResponseBody Body;
        
        public ListOfCountryNamesByCodeResponse()
        {
        }
        
        public ListOfCountryNamesByCodeResponse(ServicioVictor.ListOfCountryNamesByCodeResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class ListOfCountryNamesByCodeResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServicioVictor.tCountryCodeAndName[] ListOfCountryNamesByCodeResult;
        
        public ListOfCountryNamesByCodeResponseBody()
        {
        }
        
        public ListOfCountryNamesByCodeResponseBody(ServicioVictor.tCountryCodeAndName[] ListOfCountryNamesByCodeResult)
        {
            this.ListOfCountryNamesByCodeResult = ListOfCountryNamesByCodeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfCountryNamesByNameRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfCountryNamesByName", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.ListOfCountryNamesByNameRequestBody Body;
        
        public ListOfCountryNamesByNameRequest()
        {
        }
        
        public ListOfCountryNamesByNameRequest(ServicioVictor.ListOfCountryNamesByNameRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListOfCountryNamesByNameRequestBody
    {
        
        public ListOfCountryNamesByNameRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfCountryNamesByNameResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfCountryNamesByNameResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.ListOfCountryNamesByNameResponseBody Body;
        
        public ListOfCountryNamesByNameResponse()
        {
        }
        
        public ListOfCountryNamesByNameResponse(ServicioVictor.ListOfCountryNamesByNameResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class ListOfCountryNamesByNameResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServicioVictor.tCountryCodeAndName[] ListOfCountryNamesByNameResult;
        
        public ListOfCountryNamesByNameResponseBody()
        {
        }
        
        public ListOfCountryNamesByNameResponseBody(ServicioVictor.tCountryCodeAndName[] ListOfCountryNamesByNameResult)
        {
            this.ListOfCountryNamesByNameResult = ListOfCountryNamesByNameResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfCountryNamesGroupedByContinentRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfCountryNamesGroupedByContinent", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.ListOfCountryNamesGroupedByContinentRequestBody Body;
        
        public ListOfCountryNamesGroupedByContinentRequest()
        {
        }
        
        public ListOfCountryNamesGroupedByContinentRequest(ServicioVictor.ListOfCountryNamesGroupedByContinentRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListOfCountryNamesGroupedByContinentRequestBody
    {
        
        public ListOfCountryNamesGroupedByContinentRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfCountryNamesGroupedByContinentResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfCountryNamesGroupedByContinentResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.ListOfCountryNamesGroupedByContinentResponseBody Body;
        
        public ListOfCountryNamesGroupedByContinentResponse()
        {
        }
        
        public ListOfCountryNamesGroupedByContinentResponse(ServicioVictor.ListOfCountryNamesGroupedByContinentResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class ListOfCountryNamesGroupedByContinentResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServicioVictor.tCountryCodeAndNameGroupedByContinent[] ListOfCountryNamesGroupedByContinentResult;
        
        public ListOfCountryNamesGroupedByContinentResponseBody()
        {
        }
        
        public ListOfCountryNamesGroupedByContinentResponseBody(ServicioVictor.tCountryCodeAndNameGroupedByContinent[] ListOfCountryNamesGroupedByContinentResult)
        {
            this.ListOfCountryNamesGroupedByContinentResult = ListOfCountryNamesGroupedByContinentResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CountryNameRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CountryName", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.CountryNameRequestBody Body;
        
        public CountryNameRequest()
        {
        }
        
        public CountryNameRequest(ServicioVictor.CountryNameRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class CountryNameRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sCountryISOCode;
        
        public CountryNameRequestBody()
        {
        }
        
        public CountryNameRequestBody(string sCountryISOCode)
        {
            this.sCountryISOCode = sCountryISOCode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CountryNameResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CountryNameResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.CountryNameResponseBody Body;
        
        public CountryNameResponse()
        {
        }
        
        public CountryNameResponse(ServicioVictor.CountryNameResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class CountryNameResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CountryNameResult;
        
        public CountryNameResponseBody()
        {
        }
        
        public CountryNameResponseBody(string CountryNameResult)
        {
            this.CountryNameResult = CountryNameResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CountryISOCodeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CountryISOCode", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.CountryISOCodeRequestBody Body;
        
        public CountryISOCodeRequest()
        {
        }
        
        public CountryISOCodeRequest(ServicioVictor.CountryISOCodeRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class CountryISOCodeRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sCountryName;
        
        public CountryISOCodeRequestBody()
        {
        }
        
        public CountryISOCodeRequestBody(string sCountryName)
        {
            this.sCountryName = sCountryName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CountryISOCodeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CountryISOCodeResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.CountryISOCodeResponseBody Body;
        
        public CountryISOCodeResponse()
        {
        }
        
        public CountryISOCodeResponse(ServicioVictor.CountryISOCodeResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class CountryISOCodeResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CountryISOCodeResult;
        
        public CountryISOCodeResponseBody()
        {
        }
        
        public CountryISOCodeResponseBody(string CountryISOCodeResult)
        {
            this.CountryISOCodeResult = CountryISOCodeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CapitalCityRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CapitalCity", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.CapitalCityRequestBody Body;
        
        public CapitalCityRequest()
        {
        }
        
        public CapitalCityRequest(ServicioVictor.CapitalCityRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class CapitalCityRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sCountryISOCode;
        
        public CapitalCityRequestBody()
        {
        }
        
        public CapitalCityRequestBody(string sCountryISOCode)
        {
            this.sCountryISOCode = sCountryISOCode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CapitalCityResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CapitalCityResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.CapitalCityResponseBody Body;
        
        public CapitalCityResponse()
        {
        }
        
        public CapitalCityResponse(ServicioVictor.CapitalCityResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class CapitalCityResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CapitalCityResult;
        
        public CapitalCityResponseBody()
        {
        }
        
        public CapitalCityResponseBody(string CapitalCityResult)
        {
            this.CapitalCityResult = CapitalCityResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CountryCurrencyRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CountryCurrency", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.CountryCurrencyRequestBody Body;
        
        public CountryCurrencyRequest()
        {
        }
        
        public CountryCurrencyRequest(ServicioVictor.CountryCurrencyRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class CountryCurrencyRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sCountryISOCode;
        
        public CountryCurrencyRequestBody()
        {
        }
        
        public CountryCurrencyRequestBody(string sCountryISOCode)
        {
            this.sCountryISOCode = sCountryISOCode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CountryCurrencyResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CountryCurrencyResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.CountryCurrencyResponseBody Body;
        
        public CountryCurrencyResponse()
        {
        }
        
        public CountryCurrencyResponse(ServicioVictor.CountryCurrencyResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class CountryCurrencyResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServicioVictor.tCurrency CountryCurrencyResult;
        
        public CountryCurrencyResponseBody()
        {
        }
        
        public CountryCurrencyResponseBody(ServicioVictor.tCurrency CountryCurrencyResult)
        {
            this.CountryCurrencyResult = CountryCurrencyResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CountryFlagRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CountryFlag", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.CountryFlagRequestBody Body;
        
        public CountryFlagRequest()
        {
        }
        
        public CountryFlagRequest(ServicioVictor.CountryFlagRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class CountryFlagRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sCountryISOCode;
        
        public CountryFlagRequestBody()
        {
        }
        
        public CountryFlagRequestBody(string sCountryISOCode)
        {
            this.sCountryISOCode = sCountryISOCode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CountryFlagResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CountryFlagResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.CountryFlagResponseBody Body;
        
        public CountryFlagResponse()
        {
        }
        
        public CountryFlagResponse(ServicioVictor.CountryFlagResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class CountryFlagResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CountryFlagResult;
        
        public CountryFlagResponseBody()
        {
        }
        
        public CountryFlagResponseBody(string CountryFlagResult)
        {
            this.CountryFlagResult = CountryFlagResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CountryIntPhoneCodeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CountryIntPhoneCode", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.CountryIntPhoneCodeRequestBody Body;
        
        public CountryIntPhoneCodeRequest()
        {
        }
        
        public CountryIntPhoneCodeRequest(ServicioVictor.CountryIntPhoneCodeRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class CountryIntPhoneCodeRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sCountryISOCode;
        
        public CountryIntPhoneCodeRequestBody()
        {
        }
        
        public CountryIntPhoneCodeRequestBody(string sCountryISOCode)
        {
            this.sCountryISOCode = sCountryISOCode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CountryIntPhoneCodeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CountryIntPhoneCodeResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.CountryIntPhoneCodeResponseBody Body;
        
        public CountryIntPhoneCodeResponse()
        {
        }
        
        public CountryIntPhoneCodeResponse(ServicioVictor.CountryIntPhoneCodeResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class CountryIntPhoneCodeResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string CountryIntPhoneCodeResult;
        
        public CountryIntPhoneCodeResponseBody()
        {
        }
        
        public CountryIntPhoneCodeResponseBody(string CountryIntPhoneCodeResult)
        {
            this.CountryIntPhoneCodeResult = CountryIntPhoneCodeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FullCountryInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FullCountryInfo", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.FullCountryInfoRequestBody Body;
        
        public FullCountryInfoRequest()
        {
        }
        
        public FullCountryInfoRequest(ServicioVictor.FullCountryInfoRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class FullCountryInfoRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sCountryISOCode;
        
        public FullCountryInfoRequestBody()
        {
        }
        
        public FullCountryInfoRequestBody(string sCountryISOCode)
        {
            this.sCountryISOCode = sCountryISOCode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FullCountryInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FullCountryInfoResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.FullCountryInfoResponseBody Body;
        
        public FullCountryInfoResponse()
        {
        }
        
        public FullCountryInfoResponse(ServicioVictor.FullCountryInfoResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class FullCountryInfoResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServicioVictor.tCountryInfo FullCountryInfoResult;
        
        public FullCountryInfoResponseBody()
        {
        }
        
        public FullCountryInfoResponseBody(ServicioVictor.tCountryInfo FullCountryInfoResult)
        {
            this.FullCountryInfoResult = FullCountryInfoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FullCountryInfoAllCountriesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FullCountryInfoAllCountries", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.FullCountryInfoAllCountriesRequestBody Body;
        
        public FullCountryInfoAllCountriesRequest()
        {
        }
        
        public FullCountryInfoAllCountriesRequest(ServicioVictor.FullCountryInfoAllCountriesRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class FullCountryInfoAllCountriesRequestBody
    {
        
        public FullCountryInfoAllCountriesRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FullCountryInfoAllCountriesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FullCountryInfoAllCountriesResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.FullCountryInfoAllCountriesResponseBody Body;
        
        public FullCountryInfoAllCountriesResponse()
        {
        }
        
        public FullCountryInfoAllCountriesResponse(ServicioVictor.FullCountryInfoAllCountriesResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class FullCountryInfoAllCountriesResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServicioVictor.tCountryInfo[] FullCountryInfoAllCountriesResult;
        
        public FullCountryInfoAllCountriesResponseBody()
        {
        }
        
        public FullCountryInfoAllCountriesResponseBody(ServicioVictor.tCountryInfo[] FullCountryInfoAllCountriesResult)
        {
            this.FullCountryInfoAllCountriesResult = FullCountryInfoAllCountriesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CountriesUsingCurrencyRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CountriesUsingCurrency", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.CountriesUsingCurrencyRequestBody Body;
        
        public CountriesUsingCurrencyRequest()
        {
        }
        
        public CountriesUsingCurrencyRequest(ServicioVictor.CountriesUsingCurrencyRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class CountriesUsingCurrencyRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sISOCurrencyCode;
        
        public CountriesUsingCurrencyRequestBody()
        {
        }
        
        public CountriesUsingCurrencyRequestBody(string sISOCurrencyCode)
        {
            this.sISOCurrencyCode = sISOCurrencyCode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CountriesUsingCurrencyResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CountriesUsingCurrencyResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.CountriesUsingCurrencyResponseBody Body;
        
        public CountriesUsingCurrencyResponse()
        {
        }
        
        public CountriesUsingCurrencyResponse(ServicioVictor.CountriesUsingCurrencyResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class CountriesUsingCurrencyResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServicioVictor.tCountryCodeAndName[] CountriesUsingCurrencyResult;
        
        public CountriesUsingCurrencyResponseBody()
        {
        }
        
        public CountriesUsingCurrencyResponseBody(ServicioVictor.tCountryCodeAndName[] CountriesUsingCurrencyResult)
        {
            this.CountriesUsingCurrencyResult = CountriesUsingCurrencyResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfLanguagesByNameRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfLanguagesByName", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.ListOfLanguagesByNameRequestBody Body;
        
        public ListOfLanguagesByNameRequest()
        {
        }
        
        public ListOfLanguagesByNameRequest(ServicioVictor.ListOfLanguagesByNameRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListOfLanguagesByNameRequestBody
    {
        
        public ListOfLanguagesByNameRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfLanguagesByNameResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfLanguagesByNameResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.ListOfLanguagesByNameResponseBody Body;
        
        public ListOfLanguagesByNameResponse()
        {
        }
        
        public ListOfLanguagesByNameResponse(ServicioVictor.ListOfLanguagesByNameResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class ListOfLanguagesByNameResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServicioVictor.tLanguage[] ListOfLanguagesByNameResult;
        
        public ListOfLanguagesByNameResponseBody()
        {
        }
        
        public ListOfLanguagesByNameResponseBody(ServicioVictor.tLanguage[] ListOfLanguagesByNameResult)
        {
            this.ListOfLanguagesByNameResult = ListOfLanguagesByNameResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfLanguagesByCodeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfLanguagesByCode", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.ListOfLanguagesByCodeRequestBody Body;
        
        public ListOfLanguagesByCodeRequest()
        {
        }
        
        public ListOfLanguagesByCodeRequest(ServicioVictor.ListOfLanguagesByCodeRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListOfLanguagesByCodeRequestBody
    {
        
        public ListOfLanguagesByCodeRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfLanguagesByCodeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfLanguagesByCodeResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.ListOfLanguagesByCodeResponseBody Body;
        
        public ListOfLanguagesByCodeResponse()
        {
        }
        
        public ListOfLanguagesByCodeResponse(ServicioVictor.ListOfLanguagesByCodeResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class ListOfLanguagesByCodeResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServicioVictor.tLanguage[] ListOfLanguagesByCodeResult;
        
        public ListOfLanguagesByCodeResponseBody()
        {
        }
        
        public ListOfLanguagesByCodeResponseBody(ServicioVictor.tLanguage[] ListOfLanguagesByCodeResult)
        {
            this.ListOfLanguagesByCodeResult = ListOfLanguagesByCodeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LanguageNameRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LanguageName", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.LanguageNameRequestBody Body;
        
        public LanguageNameRequest()
        {
        }
        
        public LanguageNameRequest(ServicioVictor.LanguageNameRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class LanguageNameRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sISOCode;
        
        public LanguageNameRequestBody()
        {
        }
        
        public LanguageNameRequestBody(string sISOCode)
        {
            this.sISOCode = sISOCode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LanguageNameResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LanguageNameResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.LanguageNameResponseBody Body;
        
        public LanguageNameResponse()
        {
        }
        
        public LanguageNameResponse(ServicioVictor.LanguageNameResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class LanguageNameResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string LanguageNameResult;
        
        public LanguageNameResponseBody()
        {
        }
        
        public LanguageNameResponseBody(string LanguageNameResult)
        {
            this.LanguageNameResult = LanguageNameResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LanguageISOCodeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LanguageISOCode", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.LanguageISOCodeRequestBody Body;
        
        public LanguageISOCodeRequest()
        {
        }
        
        public LanguageISOCodeRequest(ServicioVictor.LanguageISOCodeRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class LanguageISOCodeRequestBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sLanguageName;
        
        public LanguageISOCodeRequestBody()
        {
        }
        
        public LanguageISOCodeRequestBody(string sLanguageName)
        {
            this.sLanguageName = sLanguageName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LanguageISOCodeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LanguageISOCodeResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioVictor.LanguageISOCodeResponseBody Body;
        
        public LanguageISOCodeResponse()
        {
        }
        
        public LanguageISOCodeResponse(ServicioVictor.LanguageISOCodeResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class LanguageISOCodeResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string LanguageISOCodeResult;
        
        public LanguageISOCodeResponseBody()
        {
        }
        
        public LanguageISOCodeResponseBody(string LanguageISOCodeResult)
        {
            this.LanguageISOCodeResult = LanguageISOCodeResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface CountryInfoServiceSoapTypeChannel : ServicioVictor.CountryInfoServiceSoapType, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class CountryInfoServiceSoapTypeClient : System.ServiceModel.ClientBase<ServicioVictor.CountryInfoServiceSoapType>, ServicioVictor.CountryInfoServiceSoapType
    {
        
    /// <summary>
    /// Implemente este método parcial para configurar el punto de conexión de servicio.
    /// </summary>
    /// <param name="serviceEndpoint">El punto de conexión para configurar</param>
    /// <param name="clientCredentials">Credenciales de cliente</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CountryInfoServiceSoapTypeClient(EndpointConfiguration endpointConfiguration) : 
                base(CountryInfoServiceSoapTypeClient.GetBindingForEndpoint(endpointConfiguration), CountryInfoServiceSoapTypeClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CountryInfoServiceSoapTypeClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CountryInfoServiceSoapTypeClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CountryInfoServiceSoapTypeClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CountryInfoServiceSoapTypeClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CountryInfoServiceSoapTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<ServicioVictor.ListOfContinentsByNameResponse> ListOfContinentsByNameAsync(ServicioVictor.ListOfContinentsByNameRequest request)
        {
            return base.Channel.ListOfContinentsByNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioVictor.ListOfContinentsByCodeResponse> ListOfContinentsByCodeAsync(ServicioVictor.ListOfContinentsByCodeRequest request)
        {
            return base.Channel.ListOfContinentsByCodeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioVictor.ListOfCurrenciesByNameResponse> ListOfCurrenciesByNameAsync(ServicioVictor.ListOfCurrenciesByNameRequest request)
        {
            return base.Channel.ListOfCurrenciesByNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioVictor.ListOfCurrenciesByCodeResponse> ListOfCurrenciesByCodeAsync(ServicioVictor.ListOfCurrenciesByCodeRequest request)
        {
            return base.Channel.ListOfCurrenciesByCodeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioVictor.CurrencyNameResponse> CurrencyNameAsync(ServicioVictor.CurrencyNameRequest request)
        {
            return base.Channel.CurrencyNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioVictor.ListOfCountryNamesByCodeResponse> ListOfCountryNamesByCodeAsync(ServicioVictor.ListOfCountryNamesByCodeRequest request)
        {
            return base.Channel.ListOfCountryNamesByCodeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioVictor.ListOfCountryNamesByNameResponse> ListOfCountryNamesByNameAsync(ServicioVictor.ListOfCountryNamesByNameRequest request)
        {
            return base.Channel.ListOfCountryNamesByNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioVictor.ListOfCountryNamesGroupedByContinentResponse> ListOfCountryNamesGroupedByContinentAsync(ServicioVictor.ListOfCountryNamesGroupedByContinentRequest request)
        {
            return base.Channel.ListOfCountryNamesGroupedByContinentAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioVictor.CountryNameResponse> CountryNameAsync(ServicioVictor.CountryNameRequest request)
        {
            return base.Channel.CountryNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioVictor.CountryISOCodeResponse> CountryISOCodeAsync(ServicioVictor.CountryISOCodeRequest request)
        {
            return base.Channel.CountryISOCodeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioVictor.CapitalCityResponse> CapitalCityAsync(ServicioVictor.CapitalCityRequest request)
        {
            return base.Channel.CapitalCityAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioVictor.CountryCurrencyResponse> CountryCurrencyAsync(ServicioVictor.CountryCurrencyRequest request)
        {
            return base.Channel.CountryCurrencyAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioVictor.CountryFlagResponse> CountryFlagAsync(ServicioVictor.CountryFlagRequest request)
        {
            return base.Channel.CountryFlagAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioVictor.CountryIntPhoneCodeResponse> CountryIntPhoneCodeAsync(ServicioVictor.CountryIntPhoneCodeRequest request)
        {
            return base.Channel.CountryIntPhoneCodeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioVictor.FullCountryInfoResponse> FullCountryInfoAsync(ServicioVictor.FullCountryInfoRequest request)
        {
            return base.Channel.FullCountryInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioVictor.FullCountryInfoAllCountriesResponse> FullCountryInfoAllCountriesAsync(ServicioVictor.FullCountryInfoAllCountriesRequest request)
        {
            return base.Channel.FullCountryInfoAllCountriesAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioVictor.CountriesUsingCurrencyResponse> CountriesUsingCurrencyAsync(ServicioVictor.CountriesUsingCurrencyRequest request)
        {
            return base.Channel.CountriesUsingCurrencyAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioVictor.ListOfLanguagesByNameResponse> ListOfLanguagesByNameAsync(ServicioVictor.ListOfLanguagesByNameRequest request)
        {
            return base.Channel.ListOfLanguagesByNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioVictor.ListOfLanguagesByCodeResponse> ListOfLanguagesByCodeAsync(ServicioVictor.ListOfLanguagesByCodeRequest request)
        {
            return base.Channel.ListOfLanguagesByCodeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioVictor.LanguageNameResponse> LanguageNameAsync(ServicioVictor.LanguageNameRequest request)
        {
            return base.Channel.LanguageNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioVictor.LanguageISOCodeResponse> LanguageISOCodeAsync(ServicioVictor.LanguageISOCodeRequest request)
        {
            return base.Channel.LanguageISOCodeAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.CountryInfoServiceSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.CountryInfoServiceSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.CountryInfoServiceSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://webservices.oorsprong.org/websamples.countryinfo/CountryInfoService.wso");
            }
            if ((endpointConfiguration == EndpointConfiguration.CountryInfoServiceSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://webservices.oorsprong.org/websamples.countryinfo/CountryInfoService.wso");
            }
            throw new System.InvalidOperationException(string.Format("No se pudo encontrar un punto de conexión con el nombre \"{0}\".", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            CountryInfoServiceSoap,
            
            CountryInfoServiceSoap12,
        }
    }
}
