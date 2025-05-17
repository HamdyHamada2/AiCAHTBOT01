// ========== Data/SeedData.cs ==========
using AIChatBot.Models;
using System.Linq;

namespace AIChatBot.Data
{
    public static class SeedData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Products.Any()) return;

            context.Products.AddRange(
                new Product
                {
                    Name = "بطارية",
                    Description = "وحدة تخزين للطاقة الكهربية.",
                    Usage = "تُستخدم لتشغيل الدوائر الإلكترونية.",
                    InstallationInstructions = "قم بتوصيل القطب الموجب والسالب بشكل صحيح."
                },
                new Product
                {
                    Name = "ترانزستور",
                    Description = "عنصر إلكتروني للتحكم في الإشارات.",
                    Usage = "يُستخدم كمفتاح أو مضخم للإشارة.",
                    InstallationInstructions = "ضع الأرجل الثلاثة حسب التوصيلات الصحيحة."
                },
                new Product
                {
                    Name = "IC 555",
                    Description = "دائرة متكاملة تستخدم لتوليد النبضات.",
                    Usage = "تُستخدم في المؤقتات والمذبذبات.",
                    InstallationInstructions = "توضع على البوردة مع التأكد من اتجاه الدائرة."
                }
            );

            context.SaveChanges();
        }
    }
}