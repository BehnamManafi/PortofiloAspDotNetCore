namespace Dev_portfolio.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public Article(int id, string title, string description, string image)
        {
            Id = id;
            Title = title;
            Description = description;
            Image = image;
        }

        public static List<Article> GetArticles()
        {
            return new List<Article>
        {
            new Article(
                1,
                "آموزش کامل Entity Framework Core",
                "یک راهنمای جامع برای یادگیری Entity Framework Core از مبتدی تا پیشرفته، شامل مفاهیم پایه، migrations، رابطه‌ها و بهینه‌سازی عملکرد",
                "01.png"
            ),

            new Article(
                2,
                "معماری میکروسرویس‌ها: مزایا و چالش‌ها",
                "بررسی کامل معماری میکروسرویس‌ها، مزایای استفاده از آن، چالش‌های پیاده‌سازی و بهترین practices برای توسعه",
                "02.jpg"
            ),

            new Article(
                3,
                "۱۰ الگوی طراحی ضروری در برنامه‌نویسی",
                "آشنایی با مهم‌ترین الگوهای طراحی (Design Patterns) و کاربردهای عملی آن‌ها در پروژه‌های واقعی",
                "03.jpg"
            ),

            new Article(
                4,
                "امنیت در API های RESTful",
                "راهکارهای جامع برای ایمن‌سازی APIها شامل احراز هویت JWT، اعتبارسنجی، rate limiting و logging",
                "04.png"
            ),

            new Article(
                5,
                "بهینه‌سازی عملکرد در برنامه‌های React",
                "تکنیک‌های پیشرفته برای بهبود سرعت و کارایی اپلیکیشن‌های React شامل memoization، lazy loading و virtualization",
                "05.jpg"
            ),

            new Article(
                6,
                "دocker و Kubernetes برای توسعه‌دهندگان",
                "آموزش عملی Docker و Kubernetes از نصب تا deploy کردن اپلیکیشن‌های real-world",
                "06.jpg"
            ),

            new Article(
                7,
                "برنامه‌نویسی Async در #C",
                "درک عمیق مفاهیم async/await، Task Parallel Library و مدیریت خطا در برنامه‌نویسی ناهمگام",
                "07.png"
            ),

            new Article(
                8,
                "تست نویسی حرفه‌ای با xUnit و Moq",
                "آموزش نوشتن تست‌های unit، integration و end-to-end با بهترین practices و tools",
                "blog-post-thumb-1.jpg"
            ),

            new Article(
                9,
                "پیاده‌سازی Clean Architecture در .NET",
                "گام به گام پیاده‌سازی معماری تمیز با لایه‌های مستقل، dependency injection و separation of concerns",
               "blog-post-thumb-2.jpg"
            ),

            new Article(
                10,
                "مقدمه‌ای بر هوش مصنوعی و Machine Learning",
                "آشنایی با مفاهیم پایه هوش مصنوعی، الگوریتم‌های یادگیری ماشین و کاربردهای عملی آن",
                "blog-post-thumb-3.jpg"
            ),

            new Article(
                11,
                "برنامه‌نویسی Reactive با RxJS",
                "آموزش برنامه‌نویسی reactive و مدیریت streams داده با RxJS در اپلیکیشن‌های Angular",
                "blog-post-thumb-4.jpg"
            ),

            new Article(
                12,
                "DevOps: از توسعه تا deploy",
                "آشنایی با مفاهیم DevOps، CI/CD pipelines، automation و monitoring اپلیکیشن‌ها",
                "blog-post-thumb-5.jpg"
            ),

            new Article(
                13,
                "مدیریت state در اپلیکیشن‌های بزرگ",
                "مقایسه Redux، MobX، Context API و سایر روش‌های مدیریت state در frontend",
                "blog-post-thumb-6.jpg"
            ),

            new Article(
                14,
                "برنامه‌نویسی Functional در JavaScript",
                "آموزش مفاهیم برنامه‌نویسی تابعی و استفاده از آن در پروژه‌های JavaScript و TypeScript",
                "blog-post-thumb-1.jpg"
            ),

            new Article(
                15,
                "راهنمای جامع TypeScript",
                "آموزش TypeScript از پایه تا پیشرفته، شامل types، interfaces، generics و integration با frameworks",
                "blog-post-thumb-2.jpg"
            )
        };
        }
    }
}
