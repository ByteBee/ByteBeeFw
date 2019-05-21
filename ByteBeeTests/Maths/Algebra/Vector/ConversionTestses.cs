﻿//using System;
//using ByteBee.Exceptions;
//using ByteBee.Maths.Algebra;
//using NUnit.Framework;

//namespace ByteBeeTests.Maths.Algebra.Vector
//{
//    public class ConversionTestses:AbstractVectorTests
//    {

//        [Test]
//        public void can_take_an_array()
//        {
//            double[] arr = { 1, 3, 3, 7 };
//            var v = new Vector3R(arr);

//            Assert.AreEqual(arr[0], v.X);
//        }

//        [Test]
//        public void can_take_a_tuple()
//        {
//            var t = new Tuple<double, double, double>(2, 4, 6);
//            var v = new Vector3R(t);

//            Assert.AreEqual(t.Item1, v.X);
//        }

//        [Test]
//        public void can_be_cloned()
//        {
//            var o = new Vector3R(2, 4, 6);
//            var v = new Vector3R(o);

//            Assert.AreEqual(o.X, v.X);
//        }

//        [Test]
//        public void use_vector_as_array()
//        {
//            var vector = new Vector3R(2, 4, 6);

//            Assert.AreEqual(2, vector[0]);
//            Assert.AreEqual(4, vector[1]);
//            Assert.AreEqual(6, vector[2]);
//        }

//        [Test]
//        public void get_invalid_vector_element_should_crash()
//        {
//            var vect = new Vector3R(42);

//            Assert.Throws<InvalidVectorIndexException>(() =>
//            {
//                double x = vect[4];
//            });
//        }


//        [Test]
//        public void can_convert_to_tuple()
//        {
//            Tuple<double, double, double> tuple = new Vector3R(2);

//            Assert.AreEqual(2, tuple.Item1);
//            Assert.AreEqual(2, tuple.Item2);
//            Assert.AreEqual(2, tuple.Item3);
//        }

//        [Test]
//        public void can_convert_from_tuple()
//        {
//            Vector3R vector = new Tuple<double, double, double>(2, 2, 2);

//            Assert.AreEqual(2, vector.X);
//            Assert.AreEqual(2, vector.Y);
//            Assert.AreEqual(2, vector.Z);
//        }

//        [Test]
//        public void can_convert_to_array()
//        {
//            double[] arr = new Vector3R(2);

//            Assert.AreEqual(2, arr[0]);
//            Assert.AreEqual(2, arr[1]);
//            Assert.AreEqual(2, arr[2]);
//        }

//        [Test]
//        public void can_convert_from_array()
//        {
//            Vector3R vector = new double[] { 2, 2, 2 };

//            Assert.AreEqual(2, vector.X);
//            Assert.AreEqual(2, vector.Y);
//            Assert.AreEqual(2, vector.Z);
//        }

//    }
//}