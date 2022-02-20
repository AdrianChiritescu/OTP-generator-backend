using OTP_generator.Models;

namespace OTP_generator.Services
{
    public class OTPService : IOTPService
    {
        public async Task<ServiceResponse<string>> GetLastGeneratedOTP()
        {
            return new ServiceResponse<string>();
        }

        public async Task<ServiceResponse<string>> GenerateNewOTP(OTPModel otpModel)
        {
            var generatedOtp = Enumerable.Repeat("0123456789", 6)
                                .Select(diggitsString => diggitsString[new Random().Next(diggitsString.Length)])
                                .ToArray();

            return new ServiceResponse<string>
            {
                Data = new string(generatedOtp)
            };
        }
    }
}