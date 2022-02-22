using System.Security.Cryptography.X509Certificates;

namespace WebApplication9
{

    public interface ICertificateValidationService
    {
        bool ValidateCertificate(X509Certificate2 clientCertificate);
    }

    public class SampleCertificateValidationService : ICertificateValidationService
    {
        public bool ValidateCertificate(X509Certificate2 clientCertificate)
        {
            // Don't hardcode passwords in production code.
            // Use a certificate thumbprint or Azure Key Vault.
            var expectedCertificate = new X509Certificate2("D:\\temp\\pinyo.r.pem");

            return clientCertificate.Thumbprint == expectedCertificate.Thumbprint;
        }
    }
}
