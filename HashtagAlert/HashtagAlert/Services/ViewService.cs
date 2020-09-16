using System;
using System.Collections.Generic;
using System.Text;

namespace HashtagAlert.Services
{
    public static class ViewService
    {
        public static string LoadHashtagText()
        {
            var sb = new StringBuilder();

            foreach (var line in Services.FileService.LoadFile())
            {
                sb.Append(line + "\n");
            }

            return sb.ToString();
        }
    }
}
