using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DocumentViewer.Controllers
{
    public class Document : Controller
    {
        public IActionResult Index()
        {
            //For local IIS
            string websitePath = "https://localhost:44375/";
            string LocationPath = "Content/Documents/";
            string fileName = "pan-card.jpg";
            string imageFullPath = websitePath+LocationPath + fileName;

            string livewordfile = "https://xtremethoughts.com/documents/vivekdocumentpreview.docx";
            string livepdffile = "https://xtremethoughts.com/documents/vivekdocumentpreview.docx";

            ViewBag.DocumentLocation = imageFullPath;

            //string vImageUrl = "https://drive.google.com/viewerng/viewer?embedded=true&url=https://xtremethoughts.com/Documents/VivekDocumentPreview.docx";
            string vWordUrl = "https://xtremethoughts.com/Documents/VivekDocumentPreview.docx";
            string vPdfUrl = "https://xtremethoughts.com/Documents/VivekDocumentPreview.pdf";
            string vImageUrl = "https://xtremethoughts.com/Documents/VivekDocumentPreview.jpg";
            string vPngUrl = "https://xtremethoughts.com/img/logo-startup.png";
            ViewBag.WordDocument = vWordUrl;
            ViewBag.PdfDocument = vPdfUrl;
            ViewBag.ImageDocument = vImageUrl;
            ViewBag.ImageDocument = vPngUrl;    
            //https://xtremethoughts.com/img/logo-startup.png
            return View();
        }

        public IActionResult GetWordPreview()
        {
            //For local
            //string directory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Content\\Documents\\");
            //string fileName = "pan-card.jpg";
            //string url = directory + fileName;

            //For local IIS
            string websitePath = "https://xtremethoughts.com/";
            string LocationPath = "Documents/";
            string fileName = "VivekDocumentPreview.docx";
            //string wordLink = "https://drive.google.com/viewerng/viewer?embedded=true&url=";
          
            string imageFullPath = websitePath + LocationPath + fileName;
            ViewBag.DocumentLocation = imageFullPath;
            return View();
        }

        public IActionResult GetPdfPreview()    
            {

            //For local IIS
            string websitePath = "https://xtremethoughts.com/";
            string LocationPath = "Documents/";
            string fileName = "VivekDocumentPreview.pdf";

            string imageFullPath = websitePath + LocationPath + fileName;
            ViewBag.DocumentLocation = imageFullPath;
            return View();
        }

        public IActionResult GetImagePreview()
        {
            //For local IIS
            string websitePath = "https://xtremethoughts.com/";
            string LocationPath = "Documents/";
            string fileName = "VivekDocumentPreview.jpg";

            string imageFullPath = websitePath + LocationPath + fileName;
            ViewBag.DocumentLocation = imageFullPath;
            return View();
        }



    }
}
