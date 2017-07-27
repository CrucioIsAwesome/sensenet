﻿using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SenseNet.Search.Parser;

namespace SenseNet.Search.Lucene29
{
    internal class Lucene29QueryEngine : IQueryEngine
    {
        public IQueryResult<int> ExecuteQuery(SnQuery query, IPermissionFilter filter)
        {
            var lucQuery = Compile(query);
            var queryInfo = Classify(query);
            return Execute(lucQuery, queryInfo, filter);
        }
        public IQueryResult<string> ExecuteQueryAndProject(SnQuery query, IPermissionFilter filter)
        {
            var lucQuery = Compile(query);
            var queryInfo = Classify(query);
            return ExecuteAndProject(lucQuery, queryInfo, filter);
        }

        /* ============================================================================================= */

        private LucQuery Compile(SnQuery query)
        {
            throw new NotImplementedException(); //UNDONE:! not implemented: Compile
        }
        private QueryInfo Classify(SnQuery query)
        {
            throw new NotImplementedException(); //UNDONE:! not implemented: Classify
        }

        private IQueryResult<int> Execute(LucQuery lucQuery, QueryInfo queryInfo, IPermissionFilter filter)
        {
            throw new NotImplementedException(); //UNDONE:! not implemented: Execute
        }
        private IQueryResult<string> ExecuteAndProject(LucQuery lucQuery, QueryInfo queryInfo, IPermissionFilter filter)
        {
            throw new NotImplementedException(); //UNDONE:! not implemented: ExecuteAndProject
        }
    }
}
