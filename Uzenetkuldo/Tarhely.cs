namespace Uzenetkuldo
{
    public static class Tarhely
    {
        public static string EmailCim {  get; set; }

        //Így hozunk létre listát a tárhelyhez.
        public static List<email> ElkuldottUzenetek { get; set; } = new List<email>();
    }
}
