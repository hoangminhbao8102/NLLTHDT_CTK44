using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_E_Bai1
{
    public delegate void PaperSubmissionHandler(Paper paper);
    public delegate void PaperReviewHandler(int paperId, string review, bool isAccepted);

    public class ConferenceManager
    {
        public event PaperSubmissionHandler PaperSubmitted;
        public event PaperReviewHandler PaperReviewed;

        public void SubmitPaper(Paper paper)
        {
            PaperSubmitted?.Invoke(paper);
        }

        public void ReviewPaper(int paperId, string review, bool isAccepted)
        {
            PaperReviewed?.Invoke(paperId, review, isAccepted);
        }

        public void AssignPaperToReviewer(Paper paper, List<Reviewer> reviewers)
        {
            var suitableReviewers = reviewers.Where(r => r.Expertise.Contains(paper.Topic)).OrderBy(r => r.ReviewCount).Take(3);
            foreach (var reviewer in suitableReviewers)
            {
                reviewer.ReviewCount++;
                Console.WriteLine($"Paper {paper.Title} assigned to reviewer {reviewer.Name}");
            }
        }

        public void ProcessPaperReview(int paperId, string review, bool isAccepted, List<Author> authors)
        {
            var paper = authors.SelectMany(a => a.Papers).FirstOrDefault(p => p.Id == paperId);
            if (paper != null)
            {
                paper.Reviews.Add(review);
                if (isAccepted) paper.AcceptedCount++;
                if (paper.AcceptedCount >= 2)
                {
                    Console.WriteLine($"Paper {paper.Title} is accepted for publication.");
                }
            }
        }
    }
}
