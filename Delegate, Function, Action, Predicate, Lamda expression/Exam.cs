namespace Delegate__Function__Action__Predicate__Lamda_expression
{
    internal class Exam
    {
        public string Subject { get; set; }
        public TimeSpan ExamDuration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate => StartDate.Add(ExamDuration);

        public Exam(string subject, TimeSpan examDuration, DateTime startDate)
        {
            Subject = subject;
            ExamDuration = examDuration;
            StartDate = startDate;
        }

        public override string ToString()
        {
            return $"Subject: {Subject}, Duration: {ExamDuration.TotalHours} hours";
        }
    }
}
