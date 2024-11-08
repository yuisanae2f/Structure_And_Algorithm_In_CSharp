﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_And_Algorithm.Structure.Nodes
{
    public class AbstractNode<T>
    {
        #region Member Fields
        private T? data;
        /// <summary>
        /// 노드들을 담아둔 리스트
        /// </summary>
        protected List<AbstractNode<T>?> nodeList;
        #endregion

        #region Properties
        /// <summary>
        /// 노드 데이터
        /// </summary>
        public T? Data { get => data; set => data = value; }
        #endregion

        #region Constructors
        
        public AbstractNode(T? data)
        {
            this.data = data;
            nodeList = new();
        }

        #endregion
    }
}
