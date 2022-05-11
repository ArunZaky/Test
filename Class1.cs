using NXOpen;
using NXOpen.Features;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_Point_Creation
{
    public class Class1
    {
        public static void Main()
        {
            Session session = Session.GetSession();
            Part workPart = session.Parts.Work;

            Point3d point1 = new Point3d(0, 0, 0);
            Point3d point2 = new Point3d(50, 50, 0);

            PointCollection pc = workPart.Points;
            Point p1 = pc.CreatePoint(point1);
            Point p2 = pc.CreatePoint(point2);
            //Comments

            p1.SetVisibility(SmartObject.VisibilityOption.Visible);
            p2.SetVisibility(SmartObject.VisibilityOption.Visible);

            BaseFeatureCollection bc = workPart.BaseFeatures;

            Feature pointFeature = null;

            PointFeatureBuilder pointFeatureBuilder = bc.CreatePointFeatureBuilder(pointFeature);
            pointFeatureBuilder.Point = p1;

            pointFeatureBuilder.Commit();
            pointFeatureBuilder.Destroy();

            Feature pointFeature1 = null;

            PointFeatureBuilder pointFeatureBuilder1 = bc.CreatePointFeatureBuilder(pointFeature1);
            pointFeatureBuilder1.Point = p2;


            pointFeatureBuilder1.Commit();
            pointFeatureBuilder1.Destroy();


        }
        public static int GetUnloadOption()
        {
            return 1;
        }
    }
}
