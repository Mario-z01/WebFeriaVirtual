using System.Web.Optimization;

namespace WebFeriaVirtual
{
    public class BundleConfig
    {

        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/content/css")
                .Include(
                "~/content/vendor/aos/aos.css",
                "~/content/vendor/bootstrap/css/bootstrap.min.css",
                "~/content/vendor/bootstrap-icons/bootstrap-icons.css",
                "~/content/vendor/boxicons/css/boxicons.min.css",
                "~/content/vendor/glightbox/css/glightbox.min.css",
                "~/content/vendor/swiper/swiper-bundle.min.css",
                "~/content/css/style.css"));

            bundles.Add(new ScriptBundle("~/bundles/js")
                .Include(
                "~/content/vendor/purecounter/purecounter.js",
                "~/content/vendor/aos/aos.js",
                "~/content/vendor/bootstrap/js/bootstrap.bundle.min.js",
                "~/content/vendor/glightbox/js/glightbox.min.js",
                "~/content/vendor/isotope-layout/isotope.pkgd.min.js",
                "~/content/vendor/swiper/swiper-bundle.min.js",
                "~/content/vendor/waypoints/noframework.waypoints.js",
                "~/content/vendor/php-email-form/validate.js",
                "~/content/js/main.js"));
        }


    }
}