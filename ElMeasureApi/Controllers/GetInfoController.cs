using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ElMeasureApi.Controllers
{
    [RoutePrefix("get")]
    public class GetInfoController : ApiController
    {
        [HttpGet]
        [Route("GetInfo")]
        public string getInfo(string basic,string read){
            if (basic == "basic" & Convert.ToInt32(read) >= 1) {
                return "bid0=Basic&tr0=#,VLL,VLN,A,V_phase_angle,A_phase_angle,VTHD_V,_ATHD,K_factor_V,K_factor_A&tr1=Avg,0.0000000,0.0000000,0.0000000&tr2=R(V),0.0000000,0.0000000,0.0000000,0.0000000,0.0000000,0.0000000,0.0000000,0.0000000,0.0000000&tr3=Y(B),0.0000000,0.0000000,0.0000000,0.0000000,0.0000000,0.0000000,0.0000000,0.0000000,0.0000000&tr4=B(R),0.0000000,0.0000000,0.0000000,0.0000000,0.0000000,0.0000000,0.0000000,0.0000000,0.0000000&tr5=Frequency,0.0000000&tr6=RPM,0.0000000&bid1=Power&tr0,#,Watts,VA,VAR,PF&tr1=Total,0.0000000,0.0000000,0.0000000,0.0000000&tr2=R,0.0000000,0.0000000,0.0000000,0.0000000&tr3=Y,0.0000000,0.0000000,0.0000000,0.0000000&tr4=B,0.0000000,0.0000000,0.0000000,0.0000000&";
            }
            return "";
            }
    }
}
