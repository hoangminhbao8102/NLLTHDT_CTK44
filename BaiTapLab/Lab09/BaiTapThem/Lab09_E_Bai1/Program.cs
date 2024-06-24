using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_E_Bai1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Reviewer> reviewers = new List<Reviewer>
            {
                new Reviewer { Name = "John Doe", Email = "john.doe@example.com", Workplace = "University A", Expertise = new List<string> { "AI", "ML" } },
                new Reviewer { Name = "Jane Smith", Email = "jane.smith@example.com", Workplace = "University B", Expertise = new List<string> { "AI", "Robotics" } },
                new Reviewer { Name = "Alice Johnson", Email = "alice.johnson@example.com", Workplace = "Institute C", Expertise = new List<string> { "Quantum Computing", "ML" } }
            };

            List<Author> authors = new List<Author>
            {
                new Author { Name = "Bob Brown", Email = "bob.brown@example.com", Workplace = "Tech Co.", Papers = new List<Paper>() }
            };

            Paper paper1 = new Paper
            {
                Title = "Advances in AI",
                Content = "This paper discusses recent advances in AI.",
                Topic = "AI",
                Authors = new List<Author> { authors[0] },
                MainAuthorId = authors[0].Email,
                Id = 1
            };

            authors[0].Papers.Add(paper1);

            ConferenceManager conferenceManager = new ConferenceManager();

            conferenceManager.PaperSubmitted += (Paper paper) =>
            {
                Console.WriteLine($"Paper submitted: {paper.Title}, seeking reviewers...");
                conferenceManager.AssignPaperToReviewer(paper, reviewers);
            };

            conferenceManager.PaperReviewed += (int paperId, string review, bool isAccepted) =>
            {
                Console.WriteLine($"Review received for Paper ID {paperId}: {review}, Accepted: {isAccepted}");
                conferenceManager.ProcessPaperReview(paperId, review, isAccepted, authors);
            };

            // Nộp bài báo
            conferenceManager.SubmitPaper(paper1);

            // Giả định rằng các reviewer đã review bài báo
            conferenceManager.ReviewPaper(paper1.Id, "Excellent work on AI.", true);
            conferenceManager.ReviewPaper(paper1.Id, "Needs more references.", false);
            conferenceManager.ReviewPaper(paper1.Id, "Very informative and well-written.", true);

            Console.ReadKey();
        }
    }
}
