using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookrent
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }
        public string Description { get; set; }
        public List<string> QueueUsers { get; set; } = new List<string>();

    }
    public static class BookRepository
    {
        /// <summary>
        /// 初始書籍清單
        /// </summary>
        public static List<Book> Books { get; } = new List<Book>
        {
             new Book { Title = "C#入門",            Author = "張三", IsAvailable = true,  Description = "從零開始學 C# 的最佳入門書" },
            new Book { Title = "WinForms實戰",      Author = "李四", IsAvailable = true, Description = "實作專案帶你玩 WinForms" },
            new Book { Title = "資料結構",          Author = "王五", IsAvailable = true, Description = "經典資料結構範例解析" },
            new Book { Title = "演算法分析",        Author = "趙六", IsAvailable = true,  Description = "深入探討演算法複雜度與最佳化策略" },
            new Book { Title = "資料庫系統",        Author = "孫七", IsAvailable = true,  Description = "關於關聯式資料庫設計與實作" },
            new Book { Title = "網路安全",          Author = "周八", IsAvailable = true, Description = "網路攻防與資安實務案例分析" },
            new Book { Title = "設計模式",          Author = "吳九", IsAvailable = true,  Description = "23 種軟體設計模式實例講解" },
            new Book { Title = "多執行緒",          Author = "鄭十", IsAvailable = true, Description = "C# 多執行緒與非同步程式設計" },
            new Book { Title = "LINQ 應用",         Author = "林一", IsAvailable = true,  Description = "使用 LINQ 提升資料處理效率" },
            new Book { Title = "Entity Framework Core", Author = "蔡二", IsAvailable = true, Description = "EF Core 教程與實戰" },
            new Book { Title = "Docker 入門",       Author = "許三", IsAvailable = true, Description = "容器化技術與部署實務" },
            new Book { Title = "微服務架構",         Author = "江四", IsAvailable = true,  Description = "微服務設計與實作指南" },
            new Book { Title = "RESTful API",        Author = "陳五", IsAvailable = true, Description = "使用 ASP.NET Core 架構 REST API" },
            new Book { Title = "前端開發",          Author = "蔡六", IsAvailable = true,  Description = "HTML5, CSS3, JavaScript 前端實戰" },
            new Book { Title = "React 實戰",         Author = "鄧七", IsAvailable = true,  Description = "使用 React 建構動態前端應用" },
            new Book { Title = "Vue.js 指南",        Author = "馮八", IsAvailable = true, Description = "Vue.js 全家桶與實例操作" },
            new Book { Title = "性能優化",          Author = "陳九", IsAvailable = true,  Description = "C# 與 .NET 性能診斷與優化技巧" },
            new Book { Title = "測試驅動開發",      Author = "張十", IsAvailable = true,  Description = "TDD 與單元測試最佳實踐" },
            new Book { Title = "Git 使用手冊",       Author = "李一", IsAvailable = true, Description = "版本控制與協作工作流程" },
            new Book { Title = "Azure 雲端",         Author = "王二", IsAvailable = true,  Description = "Azure 雲服務與部署實作" }
        };
        // 如需更多書籍，可於此處新增
    };
    
}
