
using CubeUtils.Interfaces;
using CubeUtils.Models;
using CubeUtils.Test.Builders;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CubeUtils.Test
{
    [TestClass]
    public class CubeManagerTest
    {
        ICubeManager cubeManager;

        [TestInitialize]
        public void TestInit()
        {
            cubeManager = new CubeManager();
        }

        [TestMethod]
        public void GetFirstCubeMatrixPosition_should_return_true()
        {
            var cube = new CubeBuilder().WithSize(4).WithCenterX(4).WithCenterY(4).WithCenterZ(4).Build();

            var point = new PointBuilder().WithX(2).WithY(2).WithZ(2).Build();

            var result = cubeManager.GetFirstCubeMatrixPosition(cube);

            Assert.IsTrue(ComparePoints(result, point));
        }

        [TestMethod]
        public void HasCollision_should_return_true()
        {
            var cube1 = new CubeBuilder().WithSize(4).WithCenterX(4).WithCenterY(4).WithCenterZ(4).Build();

            var cube2 = new CubeBuilder().WithSize(4).WithCenterX(6).WithCenterY(6).WithCenterZ(4).Build();

            var result = cubeManager.HasCollision(cube1, cube2);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void HasCollision_should_return_false()
        {
            var cube1 = new CubeBuilder().WithSize(2).WithCenterX(2).WithCenterY(2).WithCenterZ(2).Build();

            var cube2 = new CubeBuilder().WithSize(3).WithCenterX(5).WithCenterY(4).WithCenterZ(4).Build();

            var result = cubeManager.HasCollision(cube1, cube2);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void GetRestBetweenSpacesInAxis_should_Return_true()
        {
            float axisValueCube1 = 2;
            float axisValueCube2 = 4;
            float cube1Side = 4;
            float cube2Side = 4;

            float expectedResult = 2;

            var result = cubeManager.GetSubstractSpacesBetweenEdgesInAxis(axisValueCube1, axisValueCube2, cube1Side, cube2Side);

            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void GetIntersectionVolume_should_Return_true()
        {
            var cube1 = new CubeBuilder().WithSize(4).WithCenterX(4).WithCenterY(4).WithCenterZ(4).Build();

            var cube2 = new CubeBuilder().WithSize(4).WithCenterX(6).WithCenterY(6).WithCenterZ(4).Build();

            var result = cubeManager.GetIntersectionVolume(cube1, cube2);

            float expectedResult = 16; 

            Assert.AreEqual(result, expectedResult);
        }

        private bool ComparePoints(Point p1, Point p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y && p1.Z == p2.Z;
        }

    }
}
