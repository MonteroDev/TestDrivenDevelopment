using TestDrivenDevelopment.Begin.Common;

namespace TestDrivenDevelopment.Begin.Validation
{
    public static class SampleValidator
    {
        public static bool ValidateSampleName(string sampleName)
        {
            return !string.IsNullOrWhiteSpace(sampleName) && sampleName.ToLower().StartsWith(Constants.SampleNamePrefix);
        }
    }
}
