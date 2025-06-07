using Net.Pkcs11Interop.X509Store;
using System;
using System.Text;

namespace CezihECDSa
{
    public class PinProvider : IPinProvider
    {
        private readonly string _pin;

        public PinProvider(string pin)
        {
            _pin = pin;
        }

        public GetPinResult GetTokenPin(Pkcs11X509StoreInfo storeInfo, Pkcs11SlotInfo slotInfo,
            Pkcs11TokenInfo tokenInfo)
        {
            if (tokenInfo.HasProtectedAuthenticationPath)
            {
                Console.Write("Please use protected authentication path to enter token PIN...");
                return new GetPinResult(cancel: false, pin: null);
            }

            return new GetPinResult(cancel: false, pin: Encoding.UTF8.GetBytes(_pin));
        }

        public GetPinResult GetKeyPin(Pkcs11X509StoreInfo storeInfo, Pkcs11SlotInfo slotInfo, Pkcs11TokenInfo tokenInfo,
            Pkcs11X509CertificateInfo certificateInfo)
        {
            Console.WriteLine("Cancelling request for key PIN...");
            return new GetPinResult(cancel: true, pin: null);
        }
    }
}