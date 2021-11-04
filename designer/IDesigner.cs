using System.IO;

namespace Factory.designer
{
    public interface IDesigner
    {
        protected PictureDraft CreateDraft(Stream stream);
    }
}