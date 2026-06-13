public static class DegreeSummaryHelper
{
    public static Dictionary<string, int> DegreeSummary(List<Student> students)
    {
        Dictionary<string, int> summary = new Dictionary<string, int>();

        foreach (Student student in students)
        {
            string degree = student.Degree;
            if (summary.ContainsKey(degree))
            {
                summary[degree]++;
            }
            else
            {
                summary[degree] = 1;
            }
        }

        return summary;
    }
}