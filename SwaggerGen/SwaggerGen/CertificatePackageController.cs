using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SwaggerGen
{
    [Route("certificatespackage")]
    [ApiController]
    public class CertificatePackageController : ControllerBase
    {
        [HttpPatch]
        public ActionResult<Certificate> CertificatePackage(int packageId)
        {
            return new Certificate();
        }
    }

    public class Package
    {
        public Guid GxId { get; set; }
        public List<Certificate> Certificates { get; set; }
        public decimal ServiceFee { get; set; }
    }
    
    public class Certificate
    {
        public int CertificateId { get; set; }
        public decimal AmountExGst { get; set; }
        public decimal Gst { get; set; }
        public List<RequiredDataType> RequiredDataTypes { get; set; }
    }

    public class RequiredDataType
    {
        public int RequiredDataTypeId { get; set; }
        public object[] RequiredDataTypeInput { get; set; }
    }
}