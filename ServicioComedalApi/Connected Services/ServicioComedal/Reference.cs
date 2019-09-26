//------------------------------------------------------------------------------
// <generado automáticamente>
//     Este código fue generado por una herramienta.
//     //
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </generado automáticamente>
//------------------------------------------------------------------------------

namespace ServicioComedal
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
        
        private ServicioComedal.tContinent ContinentField;
        
        private ServicioComedal.tCountryCodeAndName[] CountryCodeAndNamesField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, EmitDefaultValue=false)]
        public ServicioComedal.tContinent Continent
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
        public ServicioComedal.tCountryCodeAndName[] CountryCodeAndNames
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
        
        private ServicioComedal.tLanguage[] LanguagesField;
        
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
        public ServicioComedal.tLanguage[] Languages
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo", ConfigurationName="ServicioComedal.CountryInfoServiceSoapType")]
    public interface CountryInfoServiceSoapType
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioComedal.ListOfContinentsByNameResponse> ListOfContinentsByNameAsync(ServicioComedal.ListOfContinentsByNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioComedal.ListOfContinentsByCodeResponse> ListOfContinentsByCodeAsync(ServicioComedal.ListOfContinentsByCodeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioComedal.ListOfCurrenciesByNameResponse> ListOfCurrenciesByNameAsync(ServicioComedal.ListOfCurrenciesByNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioComedal.ListOfCurrenciesByCodeResponse> ListOfCurrenciesByCodeAsync(ServicioComedal.ListOfCurrenciesByCodeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioComedal.CurrencyNameResponse> CurrencyNameAsync(ServicioComedal.CurrencyNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioComedal.ListOfCountryNamesByCodeResponse> ListOfCountryNamesByCodeAsync(ServicioComedal.ListOfCountryNamesByCodeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioComedal.ListOfCountryNamesByNameResponse> ListOfCountryNamesByNameAsync(ServicioComedal.ListOfCountryNamesByNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioComedal.ListOfCountryNamesGroupedByContinentResponse> ListOfCountryNamesGroupedByContinentAsync(ServicioComedal.ListOfCountryNamesGroupedByContinentRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioComedal.CountryNameResponse> CountryNameAsync(ServicioComedal.CountryNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioComedal.CountryISOCodeResponse> CountryISOCodeAsync(ServicioComedal.CountryISOCodeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioComedal.CapitalCityResponse> CapitalCityAsync(ServicioComedal.CapitalCityRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioComedal.CountryCurrencyResponse> CountryCurrencyAsync(ServicioComedal.CountryCurrencyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioComedal.CountryFlagResponse> CountryFlagAsync(ServicioComedal.CountryFlagRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioComedal.CountryIntPhoneCodeResponse> CountryIntPhoneCodeAsync(ServicioComedal.CountryIntPhoneCodeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioComedal.FullCountryInfoResponse> FullCountryInfoAsync(ServicioComedal.FullCountryInfoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioComedal.FullCountryInfoAllCountriesResponse> FullCountryInfoAllCountriesAsync(ServicioComedal.FullCountryInfoAllCountriesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioComedal.CountriesUsingCurrencyResponse> CountriesUsingCurrencyAsync(ServicioComedal.CountriesUsingCurrencyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioComedal.ListOfLanguagesByNameResponse> ListOfLanguagesByNameAsync(ServicioComedal.ListOfLanguagesByNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioComedal.ListOfLanguagesByCodeResponse> ListOfLanguagesByCodeAsync(ServicioComedal.ListOfLanguagesByCodeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioComedal.LanguageNameResponse> LanguageNameAsync(ServicioComedal.LanguageNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        System.Threading.Tasks.Task<ServicioComedal.LanguageISOCodeResponse> LanguageISOCodeAsync(ServicioComedal.LanguageISOCodeRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfContinentsByNameRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfContinentsByName", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.ListOfContinentsByNameRequestBody Body;
        
        public ListOfContinentsByNameRequest()
        {
        }
        
        public ListOfContinentsByNameRequest(ServicioComedal.ListOfContinentsByNameRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListOfContinentsByNameRequestBody
    {
        
        public ListOfContinentsByNameRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfContinentsByNameResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfContinentsByNameResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.ListOfContinentsByNameResponseBody Body;
        
        public ListOfContinentsByNameResponse()
        {
        }
        
        public ListOfContinentsByNameResponse(ServicioComedal.ListOfContinentsByNameResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class ListOfContinentsByNameResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServicioComedal.tContinent[] ListOfContinentsByNameResult;
        
        public ListOfContinentsByNameResponseBody()
        {
        }
        
        public ListOfContinentsByNameResponseBody(ServicioComedal.tContinent[] ListOfContinentsByNameResult)
        {
            this.ListOfContinentsByNameResult = ListOfContinentsByNameResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfContinentsByCodeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfContinentsByCode", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.ListOfContinentsByCodeRequestBody Body;
        
        public ListOfContinentsByCodeRequest()
        {
        }
        
        public ListOfContinentsByCodeRequest(ServicioComedal.ListOfContinentsByCodeRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListOfContinentsByCodeRequestBody
    {
        
        public ListOfContinentsByCodeRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfContinentsByCodeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfContinentsByCodeResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.ListOfContinentsByCodeResponseBody Body;
        
        public ListOfContinentsByCodeResponse()
        {
        }
        
        public ListOfContinentsByCodeResponse(ServicioComedal.ListOfContinentsByCodeResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class ListOfContinentsByCodeResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServicioComedal.tContinent[] ListOfContinentsByCodeResult;
        
        public ListOfContinentsByCodeResponseBody()
        {
        }
        
        public ListOfContinentsByCodeResponseBody(ServicioComedal.tContinent[] ListOfContinentsByCodeResult)
        {
            this.ListOfContinentsByCodeResult = ListOfContinentsByCodeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfCurrenciesByNameRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfCurrenciesByName", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.ListOfCurrenciesByNameRequestBody Body;
        
        public ListOfCurrenciesByNameRequest()
        {
        }
        
        public ListOfCurrenciesByNameRequest(ServicioComedal.ListOfCurrenciesByNameRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListOfCurrenciesByNameRequestBody
    {
        
        public ListOfCurrenciesByNameRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfCurrenciesByNameResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfCurrenciesByNameResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.ListOfCurrenciesByNameResponseBody Body;
        
        public ListOfCurrenciesByNameResponse()
        {
        }
        
        public ListOfCurrenciesByNameResponse(ServicioComedal.ListOfCurrenciesByNameResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class ListOfCurrenciesByNameResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServicioComedal.tCurrency[] ListOfCurrenciesByNameResult;
        
        public ListOfCurrenciesByNameResponseBody()
        {
        }
        
        public ListOfCurrenciesByNameResponseBody(ServicioComedal.tCurrency[] ListOfCurrenciesByNameResult)
        {
            this.ListOfCurrenciesByNameResult = ListOfCurrenciesByNameResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfCurrenciesByCodeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfCurrenciesByCode", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.ListOfCurrenciesByCodeRequestBody Body;
        
        public ListOfCurrenciesByCodeRequest()
        {
        }
        
        public ListOfCurrenciesByCodeRequest(ServicioComedal.ListOfCurrenciesByCodeRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListOfCurrenciesByCodeRequestBody
    {
        
        public ListOfCurrenciesByCodeRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfCurrenciesByCodeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfCurrenciesByCodeResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.ListOfCurrenciesByCodeResponseBody Body;
        
        public ListOfCurrenciesByCodeResponse()
        {
        }
        
        public ListOfCurrenciesByCodeResponse(ServicioComedal.ListOfCurrenciesByCodeResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class ListOfCurrenciesByCodeResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServicioComedal.tCurrency[] ListOfCurrenciesByCodeResult;
        
        public ListOfCurrenciesByCodeResponseBody()
        {
        }
        
        public ListOfCurrenciesByCodeResponseBody(ServicioComedal.tCurrency[] ListOfCurrenciesByCodeResult)
        {
            this.ListOfCurrenciesByCodeResult = ListOfCurrenciesByCodeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CurrencyNameRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CurrencyName", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.CurrencyNameRequestBody Body;
        
        public CurrencyNameRequest()
        {
        }
        
        public CurrencyNameRequest(ServicioComedal.CurrencyNameRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
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
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CurrencyNameResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CurrencyNameResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.CurrencyNameResponseBody Body;
        
        public CurrencyNameResponse()
        {
        }
        
        public CurrencyNameResponse(ServicioComedal.CurrencyNameResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
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
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfCountryNamesByCodeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfCountryNamesByCode", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.ListOfCountryNamesByCodeRequestBody Body;
        
        public ListOfCountryNamesByCodeRequest()
        {
        }
        
        public ListOfCountryNamesByCodeRequest(ServicioComedal.ListOfCountryNamesByCodeRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListOfCountryNamesByCodeRequestBody
    {
        
        public ListOfCountryNamesByCodeRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfCountryNamesByCodeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfCountryNamesByCodeResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.ListOfCountryNamesByCodeResponseBody Body;
        
        public ListOfCountryNamesByCodeResponse()
        {
        }
        
        public ListOfCountryNamesByCodeResponse(ServicioComedal.ListOfCountryNamesByCodeResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class ListOfCountryNamesByCodeResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServicioComedal.tCountryCodeAndName[] ListOfCountryNamesByCodeResult;
        
        public ListOfCountryNamesByCodeResponseBody()
        {
        }
        
        public ListOfCountryNamesByCodeResponseBody(ServicioComedal.tCountryCodeAndName[] ListOfCountryNamesByCodeResult)
        {
            this.ListOfCountryNamesByCodeResult = ListOfCountryNamesByCodeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfCountryNamesByNameRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfCountryNamesByName", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.ListOfCountryNamesByNameRequestBody Body;
        
        public ListOfCountryNamesByNameRequest()
        {
        }
        
        public ListOfCountryNamesByNameRequest(ServicioComedal.ListOfCountryNamesByNameRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListOfCountryNamesByNameRequestBody
    {
        
        public ListOfCountryNamesByNameRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfCountryNamesByNameResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfCountryNamesByNameResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.ListOfCountryNamesByNameResponseBody Body;
        
        public ListOfCountryNamesByNameResponse()
        {
        }
        
        public ListOfCountryNamesByNameResponse(ServicioComedal.ListOfCountryNamesByNameResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class ListOfCountryNamesByNameResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServicioComedal.tCountryCodeAndName[] ListOfCountryNamesByNameResult;
        
        public ListOfCountryNamesByNameResponseBody()
        {
        }
        
        public ListOfCountryNamesByNameResponseBody(ServicioComedal.tCountryCodeAndName[] ListOfCountryNamesByNameResult)
        {
            this.ListOfCountryNamesByNameResult = ListOfCountryNamesByNameResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfCountryNamesGroupedByContinentRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfCountryNamesGroupedByContinent", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.ListOfCountryNamesGroupedByContinentRequestBody Body;
        
        public ListOfCountryNamesGroupedByContinentRequest()
        {
        }
        
        public ListOfCountryNamesGroupedByContinentRequest(ServicioComedal.ListOfCountryNamesGroupedByContinentRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListOfCountryNamesGroupedByContinentRequestBody
    {
        
        public ListOfCountryNamesGroupedByContinentRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfCountryNamesGroupedByContinentResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfCountryNamesGroupedByContinentResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.ListOfCountryNamesGroupedByContinentResponseBody Body;
        
        public ListOfCountryNamesGroupedByContinentResponse()
        {
        }
        
        public ListOfCountryNamesGroupedByContinentResponse(ServicioComedal.ListOfCountryNamesGroupedByContinentResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class ListOfCountryNamesGroupedByContinentResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServicioComedal.tCountryCodeAndNameGroupedByContinent[] ListOfCountryNamesGroupedByContinentResult;
        
        public ListOfCountryNamesGroupedByContinentResponseBody()
        {
        }
        
        public ListOfCountryNamesGroupedByContinentResponseBody(ServicioComedal.tCountryCodeAndNameGroupedByContinent[] ListOfCountryNamesGroupedByContinentResult)
        {
            this.ListOfCountryNamesGroupedByContinentResult = ListOfCountryNamesGroupedByContinentResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CountryNameRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CountryName", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.CountryNameRequestBody Body;
        
        public CountryNameRequest()
        {
        }
        
        public CountryNameRequest(ServicioComedal.CountryNameRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
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
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CountryNameResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CountryNameResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.CountryNameResponseBody Body;
        
        public CountryNameResponse()
        {
        }
        
        public CountryNameResponse(ServicioComedal.CountryNameResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
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
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CountryISOCodeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CountryISOCode", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.CountryISOCodeRequestBody Body;
        
        public CountryISOCodeRequest()
        {
        }
        
        public CountryISOCodeRequest(ServicioComedal.CountryISOCodeRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
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
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CountryISOCodeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CountryISOCodeResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.CountryISOCodeResponseBody Body;
        
        public CountryISOCodeResponse()
        {
        }
        
        public CountryISOCodeResponse(ServicioComedal.CountryISOCodeResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
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
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CapitalCityRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CapitalCity", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.CapitalCityRequestBody Body;
        
        public CapitalCityRequest()
        {
        }
        
        public CapitalCityRequest(ServicioComedal.CapitalCityRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
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
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CapitalCityResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CapitalCityResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.CapitalCityResponseBody Body;
        
        public CapitalCityResponse()
        {
        }
        
        public CapitalCityResponse(ServicioComedal.CapitalCityResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
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
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CountryCurrencyRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CountryCurrency", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.CountryCurrencyRequestBody Body;
        
        public CountryCurrencyRequest()
        {
        }
        
        public CountryCurrencyRequest(ServicioComedal.CountryCurrencyRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
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
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CountryCurrencyResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CountryCurrencyResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.CountryCurrencyResponseBody Body;
        
        public CountryCurrencyResponse()
        {
        }
        
        public CountryCurrencyResponse(ServicioComedal.CountryCurrencyResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class CountryCurrencyResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServicioComedal.tCurrency CountryCurrencyResult;
        
        public CountryCurrencyResponseBody()
        {
        }
        
        public CountryCurrencyResponseBody(ServicioComedal.tCurrency CountryCurrencyResult)
        {
            this.CountryCurrencyResult = CountryCurrencyResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CountryFlagRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CountryFlag", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.CountryFlagRequestBody Body;
        
        public CountryFlagRequest()
        {
        }
        
        public CountryFlagRequest(ServicioComedal.CountryFlagRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
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
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CountryFlagResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CountryFlagResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.CountryFlagResponseBody Body;
        
        public CountryFlagResponse()
        {
        }
        
        public CountryFlagResponse(ServicioComedal.CountryFlagResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
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
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CountryIntPhoneCodeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CountryIntPhoneCode", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.CountryIntPhoneCodeRequestBody Body;
        
        public CountryIntPhoneCodeRequest()
        {
        }
        
        public CountryIntPhoneCodeRequest(ServicioComedal.CountryIntPhoneCodeRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
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
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CountryIntPhoneCodeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CountryIntPhoneCodeResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.CountryIntPhoneCodeResponseBody Body;
        
        public CountryIntPhoneCodeResponse()
        {
        }
        
        public CountryIntPhoneCodeResponse(ServicioComedal.CountryIntPhoneCodeResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
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
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FullCountryInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FullCountryInfo", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.FullCountryInfoRequestBody Body;
        
        public FullCountryInfoRequest()
        {
        }
        
        public FullCountryInfoRequest(ServicioComedal.FullCountryInfoRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
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
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FullCountryInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FullCountryInfoResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.FullCountryInfoResponseBody Body;
        
        public FullCountryInfoResponse()
        {
        }
        
        public FullCountryInfoResponse(ServicioComedal.FullCountryInfoResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class FullCountryInfoResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServicioComedal.tCountryInfo FullCountryInfoResult;
        
        public FullCountryInfoResponseBody()
        {
        }
        
        public FullCountryInfoResponseBody(ServicioComedal.tCountryInfo FullCountryInfoResult)
        {
            this.FullCountryInfoResult = FullCountryInfoResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FullCountryInfoAllCountriesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FullCountryInfoAllCountries", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.FullCountryInfoAllCountriesRequestBody Body;
        
        public FullCountryInfoAllCountriesRequest()
        {
        }
        
        public FullCountryInfoAllCountriesRequest(ServicioComedal.FullCountryInfoAllCountriesRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class FullCountryInfoAllCountriesRequestBody
    {
        
        public FullCountryInfoAllCountriesRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class FullCountryInfoAllCountriesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="FullCountryInfoAllCountriesResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.FullCountryInfoAllCountriesResponseBody Body;
        
        public FullCountryInfoAllCountriesResponse()
        {
        }
        
        public FullCountryInfoAllCountriesResponse(ServicioComedal.FullCountryInfoAllCountriesResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class FullCountryInfoAllCountriesResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServicioComedal.tCountryInfo[] FullCountryInfoAllCountriesResult;
        
        public FullCountryInfoAllCountriesResponseBody()
        {
        }
        
        public FullCountryInfoAllCountriesResponseBody(ServicioComedal.tCountryInfo[] FullCountryInfoAllCountriesResult)
        {
            this.FullCountryInfoAllCountriesResult = FullCountryInfoAllCountriesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CountriesUsingCurrencyRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CountriesUsingCurrency", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.CountriesUsingCurrencyRequestBody Body;
        
        public CountriesUsingCurrencyRequest()
        {
        }
        
        public CountriesUsingCurrencyRequest(ServicioComedal.CountriesUsingCurrencyRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
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
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CountriesUsingCurrencyResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CountriesUsingCurrencyResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.CountriesUsingCurrencyResponseBody Body;
        
        public CountriesUsingCurrencyResponse()
        {
        }
        
        public CountriesUsingCurrencyResponse(ServicioComedal.CountriesUsingCurrencyResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class CountriesUsingCurrencyResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServicioComedal.tCountryCodeAndName[] CountriesUsingCurrencyResult;
        
        public CountriesUsingCurrencyResponseBody()
        {
        }
        
        public CountriesUsingCurrencyResponseBody(ServicioComedal.tCountryCodeAndName[] CountriesUsingCurrencyResult)
        {
            this.CountriesUsingCurrencyResult = CountriesUsingCurrencyResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfLanguagesByNameRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfLanguagesByName", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.ListOfLanguagesByNameRequestBody Body;
        
        public ListOfLanguagesByNameRequest()
        {
        }
        
        public ListOfLanguagesByNameRequest(ServicioComedal.ListOfLanguagesByNameRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListOfLanguagesByNameRequestBody
    {
        
        public ListOfLanguagesByNameRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfLanguagesByNameResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfLanguagesByNameResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.ListOfLanguagesByNameResponseBody Body;
        
        public ListOfLanguagesByNameResponse()
        {
        }
        
        public ListOfLanguagesByNameResponse(ServicioComedal.ListOfLanguagesByNameResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class ListOfLanguagesByNameResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServicioComedal.tLanguage[] ListOfLanguagesByNameResult;
        
        public ListOfLanguagesByNameResponseBody()
        {
        }
        
        public ListOfLanguagesByNameResponseBody(ServicioComedal.tLanguage[] ListOfLanguagesByNameResult)
        {
            this.ListOfLanguagesByNameResult = ListOfLanguagesByNameResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfLanguagesByCodeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfLanguagesByCode", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.ListOfLanguagesByCodeRequestBody Body;
        
        public ListOfLanguagesByCodeRequest()
        {
        }
        
        public ListOfLanguagesByCodeRequest(ServicioComedal.ListOfLanguagesByCodeRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class ListOfLanguagesByCodeRequestBody
    {
        
        public ListOfLanguagesByCodeRequestBody()
        {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ListOfLanguagesByCodeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ListOfLanguagesByCodeResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.ListOfLanguagesByCodeResponseBody Body;
        
        public ListOfLanguagesByCodeResponse()
        {
        }
        
        public ListOfLanguagesByCodeResponse(ServicioComedal.ListOfLanguagesByCodeResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.oorsprong.org/websamples.countryinfo")]
    public partial class ListOfLanguagesByCodeResponseBody
    {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public ServicioComedal.tLanguage[] ListOfLanguagesByCodeResult;
        
        public ListOfLanguagesByCodeResponseBody()
        {
        }
        
        public ListOfLanguagesByCodeResponseBody(ServicioComedal.tLanguage[] ListOfLanguagesByCodeResult)
        {
            this.ListOfLanguagesByCodeResult = ListOfLanguagesByCodeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LanguageNameRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LanguageName", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.LanguageNameRequestBody Body;
        
        public LanguageNameRequest()
        {
        }
        
        public LanguageNameRequest(ServicioComedal.LanguageNameRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
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
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LanguageNameResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LanguageNameResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.LanguageNameResponseBody Body;
        
        public LanguageNameResponse()
        {
        }
        
        public LanguageNameResponse(ServicioComedal.LanguageNameResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
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
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LanguageISOCodeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LanguageISOCode", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.LanguageISOCodeRequestBody Body;
        
        public LanguageISOCodeRequest()
        {
        }
        
        public LanguageISOCodeRequest(ServicioComedal.LanguageISOCodeRequestBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
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
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LanguageISOCodeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LanguageISOCodeResponse", Namespace="http://www.oorsprong.org/websamples.countryinfo", Order=0)]
        public ServicioComedal.LanguageISOCodeResponseBody Body;
        
        public LanguageISOCodeResponse()
        {
        }
        
        public LanguageISOCodeResponse(ServicioComedal.LanguageISOCodeResponseBody Body)
        {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
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
    public interface CountryInfoServiceSoapTypeChannel : ServicioComedal.CountryInfoServiceSoapType, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class CountryInfoServiceSoapTypeClient : System.ServiceModel.ClientBase<ServicioComedal.CountryInfoServiceSoapType>, ServicioComedal.CountryInfoServiceSoapType
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
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServicioComedal.ListOfContinentsByNameResponse> ServicioComedal.CountryInfoServiceSoapType.ListOfContinentsByNameAsync(ServicioComedal.ListOfContinentsByNameRequest request)
        {
            return base.Channel.ListOfContinentsByNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioComedal.ListOfContinentsByNameResponse> ListOfContinentsByNameAsync()
        {
            ServicioComedal.ListOfContinentsByNameRequest inValue = new ServicioComedal.ListOfContinentsByNameRequest();
            inValue.Body = new ServicioComedal.ListOfContinentsByNameRequestBody();
            return ((ServicioComedal.CountryInfoServiceSoapType)(this)).ListOfContinentsByNameAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServicioComedal.ListOfContinentsByCodeResponse> ServicioComedal.CountryInfoServiceSoapType.ListOfContinentsByCodeAsync(ServicioComedal.ListOfContinentsByCodeRequest request)
        {
            return base.Channel.ListOfContinentsByCodeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioComedal.ListOfContinentsByCodeResponse> ListOfContinentsByCodeAsync()
        {
            ServicioComedal.ListOfContinentsByCodeRequest inValue = new ServicioComedal.ListOfContinentsByCodeRequest();
            inValue.Body = new ServicioComedal.ListOfContinentsByCodeRequestBody();
            return ((ServicioComedal.CountryInfoServiceSoapType)(this)).ListOfContinentsByCodeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServicioComedal.ListOfCurrenciesByNameResponse> ServicioComedal.CountryInfoServiceSoapType.ListOfCurrenciesByNameAsync(ServicioComedal.ListOfCurrenciesByNameRequest request)
        {
            return base.Channel.ListOfCurrenciesByNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioComedal.ListOfCurrenciesByNameResponse> ListOfCurrenciesByNameAsync()
        {
            ServicioComedal.ListOfCurrenciesByNameRequest inValue = new ServicioComedal.ListOfCurrenciesByNameRequest();
            inValue.Body = new ServicioComedal.ListOfCurrenciesByNameRequestBody();
            return ((ServicioComedal.CountryInfoServiceSoapType)(this)).ListOfCurrenciesByNameAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServicioComedal.ListOfCurrenciesByCodeResponse> ServicioComedal.CountryInfoServiceSoapType.ListOfCurrenciesByCodeAsync(ServicioComedal.ListOfCurrenciesByCodeRequest request)
        {
            return base.Channel.ListOfCurrenciesByCodeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioComedal.ListOfCurrenciesByCodeResponse> ListOfCurrenciesByCodeAsync()
        {
            ServicioComedal.ListOfCurrenciesByCodeRequest inValue = new ServicioComedal.ListOfCurrenciesByCodeRequest();
            inValue.Body = new ServicioComedal.ListOfCurrenciesByCodeRequestBody();
            return ((ServicioComedal.CountryInfoServiceSoapType)(this)).ListOfCurrenciesByCodeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServicioComedal.CurrencyNameResponse> ServicioComedal.CountryInfoServiceSoapType.CurrencyNameAsync(ServicioComedal.CurrencyNameRequest request)
        {
            return base.Channel.CurrencyNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioComedal.CurrencyNameResponse> CurrencyNameAsync(string sCurrencyISOCode)
        {
            ServicioComedal.CurrencyNameRequest inValue = new ServicioComedal.CurrencyNameRequest();
            inValue.Body = new ServicioComedal.CurrencyNameRequestBody();
            inValue.Body.sCurrencyISOCode = sCurrencyISOCode;
            return ((ServicioComedal.CountryInfoServiceSoapType)(this)).CurrencyNameAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServicioComedal.ListOfCountryNamesByCodeResponse> ServicioComedal.CountryInfoServiceSoapType.ListOfCountryNamesByCodeAsync(ServicioComedal.ListOfCountryNamesByCodeRequest request)
        {
            return base.Channel.ListOfCountryNamesByCodeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioComedal.ListOfCountryNamesByCodeResponse> ListOfCountryNamesByCodeAsync()
        {
            ServicioComedal.ListOfCountryNamesByCodeRequest inValue = new ServicioComedal.ListOfCountryNamesByCodeRequest();
            inValue.Body = new ServicioComedal.ListOfCountryNamesByCodeRequestBody();
            return ((ServicioComedal.CountryInfoServiceSoapType)(this)).ListOfCountryNamesByCodeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServicioComedal.ListOfCountryNamesByNameResponse> ServicioComedal.CountryInfoServiceSoapType.ListOfCountryNamesByNameAsync(ServicioComedal.ListOfCountryNamesByNameRequest request)
        {
            return base.Channel.ListOfCountryNamesByNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioComedal.ListOfCountryNamesByNameResponse> ListOfCountryNamesByNameAsync()
        {
            ServicioComedal.ListOfCountryNamesByNameRequest inValue = new ServicioComedal.ListOfCountryNamesByNameRequest();
            inValue.Body = new ServicioComedal.ListOfCountryNamesByNameRequestBody();
            return ((ServicioComedal.CountryInfoServiceSoapType)(this)).ListOfCountryNamesByNameAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServicioComedal.ListOfCountryNamesGroupedByContinentResponse> ServicioComedal.CountryInfoServiceSoapType.ListOfCountryNamesGroupedByContinentAsync(ServicioComedal.ListOfCountryNamesGroupedByContinentRequest request)
        {
            return base.Channel.ListOfCountryNamesGroupedByContinentAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioComedal.ListOfCountryNamesGroupedByContinentResponse> ListOfCountryNamesGroupedByContinentAsync()
        {
            ServicioComedal.ListOfCountryNamesGroupedByContinentRequest inValue = new ServicioComedal.ListOfCountryNamesGroupedByContinentRequest();
            inValue.Body = new ServicioComedal.ListOfCountryNamesGroupedByContinentRequestBody();
            return ((ServicioComedal.CountryInfoServiceSoapType)(this)).ListOfCountryNamesGroupedByContinentAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServicioComedal.CountryNameResponse> ServicioComedal.CountryInfoServiceSoapType.CountryNameAsync(ServicioComedal.CountryNameRequest request)
        {
            return base.Channel.CountryNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioComedal.CountryNameResponse> CountryNameAsync(string sCountryISOCode)
        {
            ServicioComedal.CountryNameRequest inValue = new ServicioComedal.CountryNameRequest();
            inValue.Body = new ServicioComedal.CountryNameRequestBody();
            inValue.Body.sCountryISOCode = sCountryISOCode;
            return ((ServicioComedal.CountryInfoServiceSoapType)(this)).CountryNameAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServicioComedal.CountryISOCodeResponse> ServicioComedal.CountryInfoServiceSoapType.CountryISOCodeAsync(ServicioComedal.CountryISOCodeRequest request)
        {
            return base.Channel.CountryISOCodeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioComedal.CountryISOCodeResponse> CountryISOCodeAsync(string sCountryName)
        {
            ServicioComedal.CountryISOCodeRequest inValue = new ServicioComedal.CountryISOCodeRequest();
            inValue.Body = new ServicioComedal.CountryISOCodeRequestBody();
            inValue.Body.sCountryName = sCountryName;
            return ((ServicioComedal.CountryInfoServiceSoapType)(this)).CountryISOCodeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServicioComedal.CapitalCityResponse> ServicioComedal.CountryInfoServiceSoapType.CapitalCityAsync(ServicioComedal.CapitalCityRequest request)
        {
            return base.Channel.CapitalCityAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioComedal.CapitalCityResponse> CapitalCityAsync(string sCountryISOCode)
        {
            ServicioComedal.CapitalCityRequest inValue = new ServicioComedal.CapitalCityRequest();
            inValue.Body = new ServicioComedal.CapitalCityRequestBody();
            inValue.Body.sCountryISOCode = sCountryISOCode;
            return ((ServicioComedal.CountryInfoServiceSoapType)(this)).CapitalCityAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServicioComedal.CountryCurrencyResponse> ServicioComedal.CountryInfoServiceSoapType.CountryCurrencyAsync(ServicioComedal.CountryCurrencyRequest request)
        {
            return base.Channel.CountryCurrencyAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioComedal.CountryCurrencyResponse> CountryCurrencyAsync(string sCountryISOCode)
        {
            ServicioComedal.CountryCurrencyRequest inValue = new ServicioComedal.CountryCurrencyRequest();
            inValue.Body = new ServicioComedal.CountryCurrencyRequestBody();
            inValue.Body.sCountryISOCode = sCountryISOCode;
            return ((ServicioComedal.CountryInfoServiceSoapType)(this)).CountryCurrencyAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServicioComedal.CountryFlagResponse> ServicioComedal.CountryInfoServiceSoapType.CountryFlagAsync(ServicioComedal.CountryFlagRequest request)
        {
            return base.Channel.CountryFlagAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioComedal.CountryFlagResponse> CountryFlagAsync(string sCountryISOCode)
        {
            ServicioComedal.CountryFlagRequest inValue = new ServicioComedal.CountryFlagRequest();
            inValue.Body = new ServicioComedal.CountryFlagRequestBody();
            inValue.Body.sCountryISOCode = sCountryISOCode;
            return ((ServicioComedal.CountryInfoServiceSoapType)(this)).CountryFlagAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServicioComedal.CountryIntPhoneCodeResponse> ServicioComedal.CountryInfoServiceSoapType.CountryIntPhoneCodeAsync(ServicioComedal.CountryIntPhoneCodeRequest request)
        {
            return base.Channel.CountryIntPhoneCodeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioComedal.CountryIntPhoneCodeResponse> CountryIntPhoneCodeAsync(string sCountryISOCode)
        {
            ServicioComedal.CountryIntPhoneCodeRequest inValue = new ServicioComedal.CountryIntPhoneCodeRequest();
            inValue.Body = new ServicioComedal.CountryIntPhoneCodeRequestBody();
            inValue.Body.sCountryISOCode = sCountryISOCode;
            return ((ServicioComedal.CountryInfoServiceSoapType)(this)).CountryIntPhoneCodeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServicioComedal.FullCountryInfoResponse> ServicioComedal.CountryInfoServiceSoapType.FullCountryInfoAsync(ServicioComedal.FullCountryInfoRequest request)
        {
            return base.Channel.FullCountryInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioComedal.FullCountryInfoResponse> FullCountryInfoAsync(string sCountryISOCode)
        {
            ServicioComedal.FullCountryInfoRequest inValue = new ServicioComedal.FullCountryInfoRequest();
            inValue.Body = new ServicioComedal.FullCountryInfoRequestBody();
            inValue.Body.sCountryISOCode = sCountryISOCode;
            return ((ServicioComedal.CountryInfoServiceSoapType)(this)).FullCountryInfoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServicioComedal.FullCountryInfoAllCountriesResponse> ServicioComedal.CountryInfoServiceSoapType.FullCountryInfoAllCountriesAsync(ServicioComedal.FullCountryInfoAllCountriesRequest request)
        {
            return base.Channel.FullCountryInfoAllCountriesAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioComedal.FullCountryInfoAllCountriesResponse> FullCountryInfoAllCountriesAsync()
        {
            ServicioComedal.FullCountryInfoAllCountriesRequest inValue = new ServicioComedal.FullCountryInfoAllCountriesRequest();
            inValue.Body = new ServicioComedal.FullCountryInfoAllCountriesRequestBody();
            return ((ServicioComedal.CountryInfoServiceSoapType)(this)).FullCountryInfoAllCountriesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServicioComedal.CountriesUsingCurrencyResponse> ServicioComedal.CountryInfoServiceSoapType.CountriesUsingCurrencyAsync(ServicioComedal.CountriesUsingCurrencyRequest request)
        {
            return base.Channel.CountriesUsingCurrencyAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioComedal.CountriesUsingCurrencyResponse> CountriesUsingCurrencyAsync(string sISOCurrencyCode)
        {
            ServicioComedal.CountriesUsingCurrencyRequest inValue = new ServicioComedal.CountriesUsingCurrencyRequest();
            inValue.Body = new ServicioComedal.CountriesUsingCurrencyRequestBody();
            inValue.Body.sISOCurrencyCode = sISOCurrencyCode;
            return ((ServicioComedal.CountryInfoServiceSoapType)(this)).CountriesUsingCurrencyAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServicioComedal.ListOfLanguagesByNameResponse> ServicioComedal.CountryInfoServiceSoapType.ListOfLanguagesByNameAsync(ServicioComedal.ListOfLanguagesByNameRequest request)
        {
            return base.Channel.ListOfLanguagesByNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioComedal.ListOfLanguagesByNameResponse> ListOfLanguagesByNameAsync()
        {
            ServicioComedal.ListOfLanguagesByNameRequest inValue = new ServicioComedal.ListOfLanguagesByNameRequest();
            inValue.Body = new ServicioComedal.ListOfLanguagesByNameRequestBody();
            return ((ServicioComedal.CountryInfoServiceSoapType)(this)).ListOfLanguagesByNameAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServicioComedal.ListOfLanguagesByCodeResponse> ServicioComedal.CountryInfoServiceSoapType.ListOfLanguagesByCodeAsync(ServicioComedal.ListOfLanguagesByCodeRequest request)
        {
            return base.Channel.ListOfLanguagesByCodeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioComedal.ListOfLanguagesByCodeResponse> ListOfLanguagesByCodeAsync()
        {
            ServicioComedal.ListOfLanguagesByCodeRequest inValue = new ServicioComedal.ListOfLanguagesByCodeRequest();
            inValue.Body = new ServicioComedal.ListOfLanguagesByCodeRequestBody();
            return ((ServicioComedal.CountryInfoServiceSoapType)(this)).ListOfLanguagesByCodeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServicioComedal.LanguageNameResponse> ServicioComedal.CountryInfoServiceSoapType.LanguageNameAsync(ServicioComedal.LanguageNameRequest request)
        {
            return base.Channel.LanguageNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioComedal.LanguageNameResponse> LanguageNameAsync(string sISOCode)
        {
            ServicioComedal.LanguageNameRequest inValue = new ServicioComedal.LanguageNameRequest();
            inValue.Body = new ServicioComedal.LanguageNameRequestBody();
            inValue.Body.sISOCode = sISOCode;
            return ((ServicioComedal.CountryInfoServiceSoapType)(this)).LanguageNameAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServicioComedal.LanguageISOCodeResponse> ServicioComedal.CountryInfoServiceSoapType.LanguageISOCodeAsync(ServicioComedal.LanguageISOCodeRequest request)
        {
            return base.Channel.LanguageISOCodeAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServicioComedal.LanguageISOCodeResponse> LanguageISOCodeAsync(string sLanguageName)
        {
            ServicioComedal.LanguageISOCodeRequest inValue = new ServicioComedal.LanguageISOCodeRequest();
            inValue.Body = new ServicioComedal.LanguageISOCodeRequestBody();
            inValue.Body.sLanguageName = sLanguageName;
            return ((ServicioComedal.CountryInfoServiceSoapType)(this)).LanguageISOCodeAsync(inValue);
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
