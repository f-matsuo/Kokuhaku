using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kokuhaku.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kokuhaku.Models.Tests;
using System.Web.Mvc;
using Kokuhaku.Models;

namespace Kokuhaku.Controllers.Tests
{
    [TestClass]
    public class kokuhakuControllerTests
    {
        private kokuhakuController ctrl;

        //テストの初期化処理
        [TestInitialize]
        public void MyTestInitialize()
        {
            //テスト用のリポジトリをコントローラーに設定
            this.ctrl = new kokuhakuController(new detaRepositoryTests());
        }

        [TestMethod()]
        public void IndexTest()
        {
            /*
            //アクションを実行
            var result = this.ctrl.Index() as ViewResult;
            //取得したオブジェクトの件数をチェック
            Assert.AreEqual(3, ((IEnumerable<deta>)result.Model).Count());
            Assert.AreEqual(3, ((IEnumerable<ohenzi>)result.Model).Count());
            Assert.AreEqual(3, ((IEnumerable<riyuu>)result.Model).Count());
            */
        }

        [TestMethod()]
        public void SelectTest()
        {
            //アクション実行
            var result = this.ctrl.mail(1, 2, 1, "なめああああああああああああああああ") as ViewResult;
            //取得したオブジェクトの件数をチェック
            Assert.AreEqual(1, ((IEnumerable<matome>)result.Model).Count());
        }
    }
}