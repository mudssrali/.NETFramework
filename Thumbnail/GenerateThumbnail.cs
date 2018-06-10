public Object GetThumbnail(string uniqueName)
        {

             // Physical path of root folder
            var rootPath = HttpContext.Current.Server.MapPath("~/UploadedFiles");

            // Find file from DB using unique name
            var FileDTO = FileBO.GetFile(uniqueName);
            var fileaFullPath = Path.Combine(rootPath, FileDTO.UniqueName + FileDTO.Extension);

            ShellFile shellFile = ShellFile.FromFilePath(fileFullPath);
            Bitmap shellThumb = shellFile.Thumbnail.MediumBitmap;

            if (FileDTO != null)
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK);

                byte[] file = ImageToBytes(shellThumb); // Calling private ImageToBytes

                MemoryStream ms = new MemoryStream(file);

                response.Content = new ByteArrayContent(file);
                response.Content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("attachment");

                response.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(FileDTO.FileType);
                response.Content.Headers.ContentDisposition.FileName = FileDTO.Name;
                return response;
            }
            else
            {
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.NotFound);
                return response;
            }

        }
        private byte[] ImageToBytes(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }