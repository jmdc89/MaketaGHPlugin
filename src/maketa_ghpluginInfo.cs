using System;
using System.Drawing;
using Grasshopper;
using Grasshopper.Kernel;

namespace maketa_ghplugin
{
    public class maketa_ghpluginInfo : GH_AssemblyInfo
    {
        public override string Name => "maketa_ghplugin";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("e64a246c-13b7-49ff-a0b3-858cc914205b");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}