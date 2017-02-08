using Magazine.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Controller {
    class PaperController {
        public static List<paper> GetPapers(user user) {
            if (user.GROUP_id == 1) {
                return AccountController.entities.papers.Where(p => p.Author == user.id).ToList();
            }
            else if (user.GROUP_id == 2) {
                return AccountController.entities.papers.Where(p => p.Editor == null || p.Editor == user.id).ToList();
            }
            return AccountController.entities.papers.ToList();
        }

        public static List<file> GetSubmissions(paper p) {
            return p.files.ToList();
        }

        public static void UploadSubmission(paper p, string filePath) {
            byte[] fileBytes = File.ReadAllBytes(filePath);
            string[] list = filePath.Split('\\');
            string extension = list[list.Length - 1].Split('.')[1];
            file f = new file();
            f.Content = fileBytes;
            f.Extension = extension;
            f.paper = p;
            AccountController.entities.files.Add(f);
            AccountController.entities.SaveChanges();
        }

        public static void AddPaper(string title, string filePath) {
            paper p = new paper();
            p.Title = title;
            p.STATUS_id = 1;
            p.author_user = AccountController.User;
            AccountController.entities.papers.Add(p);
            UploadSubmission(p, filePath);
        }

        public static int GetLatestVersion(int paperId) {
            return AccountController.entities.files.Where(f => f.PAPER_id == paperId).Select(f => f.id).Max();
        }

        public static byte[] GetFile(int id) {
            return AccountController.entities.files.Where(f => f.id == id).Select(f => f.Content).First();
        }
    }
}
