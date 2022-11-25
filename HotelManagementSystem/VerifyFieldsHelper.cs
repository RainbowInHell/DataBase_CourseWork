
namespace HotelManagementSystem
{
    public static class VerifyFieldsHelper
    {
        public static bool IsAnyOfFieldsNullOrEmpty(params string[] values)
        {
            return values.Any(x => string.IsNullOrEmpty(x)) ? true : false;
        }
    }
}
