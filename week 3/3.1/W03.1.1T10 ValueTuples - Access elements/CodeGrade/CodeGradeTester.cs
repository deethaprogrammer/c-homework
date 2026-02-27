static class CodeGradeTester
{
    public static void Main(string[] args)
    {
        switch (args[1])
        {
            case "PrintResults": TestPrintResults(); return;
            case "GetAndPrintResults": TestGetAndPrintResults(); return;
            default: throw new ArgumentOutOfRangeException($"{args[1]}", $"Unexpected args value: {args[1]}");
        }
    }

    public static void TestPrintResults()
    {
        TestUtils.PrintTupleParameterNames(typeof(TestResultProcessor), "PrintTestResult");

        (double Grade, bool HasPassed)[] results = [
            (5.5, true),
            (10.0, true),
            (5.6, true),
            (5.4, false),
            (2.5, false),
        ];

        foreach (var result in results)
        {
            TestResultProcessor.PrintTestResult(result);
        }
    }

    public static void TestGetAndPrintResults()
    {
        int[] pointsObtained = [0, 55, 100];
        int[] maxPoints = [100, 200];
        foreach (int max in maxPoints)
        {
            foreach (int points in pointsObtained)
            {
                (double Grade, bool HasPassed) result = TestResultProcessor.GetTestResult(points, max);
                TestResultProcessor.PrintTestResult(result);
            }
        }
    }
}
