using System;

namespace Microsoft.SqlServer.TransactSql.ScriptDom
{
    public abstract class TSqlFragmentVisitor
    {
        private readonly bool _visitBaseType;

        internal bool VisitBaseType
        {
            get
            {
                return this._visitBaseType;
            }
        }

        protected TSqlFragmentVisitor() : this(true)
        {
        }

        internal TSqlFragmentVisitor(bool visitBaseType)
        {
            this._visitBaseType = visitBaseType;
        }

        public virtual void ExplicitVisit(StatementList node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExecuteStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExecuteOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ResultSetsExecuteOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ExecuteOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ResultSetDefinition node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(InlineResultSetDefinition node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ResultSetDefinition)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ResultColumnDefinition node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SchemaObjectResultSetDefinition node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ResultSetDefinition)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExecuteSpecification node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExecuteContext node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExecuteParameter node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExecutableEntity node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ProcedureReferenceName node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExecutableProcedureReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ExecutableEntity)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExecutableStringList node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ExecutableEntity)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AdHocDataSource node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ViewOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterViewStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ViewStatementBody)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateViewStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ViewStatementBody)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateOrAlterViewStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ViewStatementBody)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ViewStatementBody node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TriggerObject node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TriggerOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExecuteAsTriggerOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TriggerOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TriggerAction node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterTriggerStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TriggerStatementBody)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateTriggerStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TriggerStatementBody)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateOrAlterTriggerStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TriggerStatementBody)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TriggerStatementBody node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(Identifier node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterProcedureStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ProcedureStatementBody)node);
                this.Visit((ProcedureStatementBodyBase)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateProcedureStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ProcedureStatementBody)node);
                this.Visit((ProcedureStatementBodyBase)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateOrAlterProcedureStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ProcedureStatementBody)node);
                this.Visit((ProcedureStatementBodyBase)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ProcedureReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(MethodSpecifier node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ProcedureStatementBody node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ProcedureStatementBodyBase)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ProcedureStatementBodyBase node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FunctionStatementBody node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ProcedureStatementBodyBase)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ProcedureOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExecuteAsProcedureOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ProcedureOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FunctionOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExecuteAsFunctionOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((FunctionOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(XmlNamespaces node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(XmlNamespacesElement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(XmlNamespacesDefaultElement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((XmlNamespacesElement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(XmlNamespacesAliasElement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((XmlNamespacesElement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CommonTableExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(WithCtesAndXmlNamespaces node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FunctionReturnType node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TableValuedFunctionReturnType node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((FunctionReturnType)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DataTypeReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ParameterizedDataTypeReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DataTypeReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SqlDataTypeReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ParameterizedDataTypeReference)node);
                this.Visit((DataTypeReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(UserDataTypeReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ParameterizedDataTypeReference)node);
                this.Visit((DataTypeReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(XmlDataTypeReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DataTypeReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ScalarFunctionReturnType node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((FunctionReturnType)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SelectFunctionReturnType node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((FunctionReturnType)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TableDefinition node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DeclareTableVariableBody node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DeclareTableVariableStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(NamedTableReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableReferenceWithAlias)node);
                this.Visit((TableReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SchemaObjectFunctionTableReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableReferenceWithAliasAndColumns)node);
                this.Visit((TableReferenceWithAlias)node);
                this.Visit((TableReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TableHint node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(IndexTableHint node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableHint)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(LiteralTableHint node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableHint)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(QueryDerivedTable node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableReferenceWithAliasAndColumns)node);
                this.Visit((TableReferenceWithAlias)node);
                this.Visit((TableReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(InlineDerivedTable node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableReferenceWithAliasAndColumns)node);
                this.Visit((TableReferenceWithAlias)node);
                this.Visit((TableReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SubqueryComparisonPredicate node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BooleanExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExistsPredicate node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BooleanExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(LikePredicate node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BooleanExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(InPredicate node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BooleanExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FullTextPredicate node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BooleanExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(UserDefinedTypePropertyAccess node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(StatementWithCtesAndXmlNamespaces node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SelectStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((StatementWithCtesAndXmlNamespaces)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ForClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BrowseForClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ForClause)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ReadOnlyForClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ForClause)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(XmlForClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ForClause)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(XmlForClauseOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ForClause)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(JsonForClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ForClause)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(JsonForClauseOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ForClause)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(UpdateForClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ForClause)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OptimizerHint node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(LiteralOptimizerHint node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((OptimizerHint)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TableHintsOptimizerHint node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((OptimizerHint)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ForceSeekTableHint node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableHint)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OptimizeForOptimizerHint node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((OptimizerHint)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(UseHintList node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((OptimizerHint)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(VariableValuePair node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(WhenClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SimpleWhenClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((WhenClause)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SearchedWhenClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((WhenClause)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CaseExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SimpleCaseExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((CaseExpression)node);
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SearchedCaseExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((CaseExpression)node);
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(NullIfExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CoalesceExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(IIfCall node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FullTextTableReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableReferenceWithAlias)node);
                this.Visit((TableReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SemanticTableReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableReferenceWithAlias)node);
                this.Visit((TableReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OpenXmlTableReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableReferenceWithAlias)node);
                this.Visit((TableReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OpenJsonTableReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableReferenceWithAlias)node);
                this.Visit((TableReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OpenRowsetTableReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableReferenceWithAlias)node);
                this.Visit((TableReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(InternalOpenRowset node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableReferenceWithAlias)node);
                this.Visit((TableReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BulkOpenRowset node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableReferenceWithAliasAndColumns)node);
                this.Visit((TableReferenceWithAlias)node);
                this.Visit((TableReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OpenQueryTableReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableReferenceWithAlias)node);
                this.Visit((TableReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AdHocTableReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableReferenceWithAlias)node);
                this.Visit((TableReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SchemaDeclarationItem node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SchemaDeclarationItemOpenjson node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SchemaDeclarationItem)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ConvertCall node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TryConvertCall node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ParseCall node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TryParseCall node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CastCall node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TryCastCall node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AtTimeZoneCall node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FunctionCall node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CallTarget node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExpressionCallTarget node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((CallTarget)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(MultiPartIdentifierCallTarget node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((CallTarget)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(UserDefinedTypeCallTarget node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((CallTarget)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(LeftFunctionCall node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RightFunctionCall node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(PartitionFunctionCall node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OverClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ParameterlessCall node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ScalarSubquery node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OdbcFunctionCall node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExtractFromExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OdbcConvertSpecification node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterFunctionStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((FunctionStatementBody)node);
                this.Visit((ProcedureStatementBodyBase)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BeginEndBlockStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BeginEndAtomicBlockStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BeginEndBlockStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AtomicBlockOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(LiteralAtomicBlockOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AtomicBlockOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(IdentifierAtomicBlockOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AtomicBlockOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OnOffAtomicBlockOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AtomicBlockOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BeginTransactionStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TransactionStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BreakStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ColumnWithSortOrder node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CommitTransactionStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TransactionStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RollbackTransactionStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TransactionStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SaveTransactionStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TransactionStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ContinueStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateDefaultStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateFunctionStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((FunctionStatementBody)node);
                this.Visit((ProcedureStatementBodyBase)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateOrAlterFunctionStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((FunctionStatementBody)node);
                this.Visit((ProcedureStatementBodyBase)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateRuleStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DeclareVariableElement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DeclareVariableStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(GoToStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(IfStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(LabelStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(MultiPartIdentifier node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SchemaObjectName node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((MultiPartIdentifier)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ChildObjectName node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SchemaObjectName)node);
                this.Visit((MultiPartIdentifier)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ProcedureParameter node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DeclareVariableElement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TransactionStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(WhileStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DeleteStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DataModificationStatement)node);
                this.Visit((StatementWithCtesAndXmlNamespaces)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(UpdateDeleteSpecificationBase node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DataModificationSpecification)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DeleteSpecification node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((UpdateDeleteSpecificationBase)node);
                this.Visit((DataModificationSpecification)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(InsertStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DataModificationStatement)node);
                this.Visit((StatementWithCtesAndXmlNamespaces)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(InsertSpecification node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DataModificationSpecification)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(UpdateStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DataModificationStatement)node);
                this.Visit((StatementWithCtesAndXmlNamespaces)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(UpdateSpecification node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((UpdateDeleteSpecificationBase)node);
                this.Visit((DataModificationSpecification)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateSchemaStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(WaitForStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ReadTextStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(UpdateTextStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TextModificationStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(WriteTextStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TextModificationStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TextModificationStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(LineNoStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SecurityStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(GrantStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SecurityStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DenyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SecurityStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RevokeStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SecurityStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterAuthorizationStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(Permission node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SecurityTargetObject node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SecurityTargetObjectName node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SecurityPrincipal node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SecurityStatementBody80 node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(GrantStatement80 node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SecurityStatementBody80)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DenyStatement80 node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SecurityStatementBody80)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RevokeStatement80 node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SecurityStatementBody80)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SecurityElement80 node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CommandSecurityElement80 node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SecurityElement80)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(PrivilegeSecurityElement80 node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SecurityElement80)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(Privilege80 node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SecurityUserClause80 node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SqlCommandIdentifier node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((Identifier)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SetClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AssignmentSetClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SetClause)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FunctionCallSetClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SetClause)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(InsertSource node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ValuesInsertSource node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((InsertSource)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SelectInsertSource node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((InsertSource)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExecuteInsertSource node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((InsertSource)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RowValue node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(PrintStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(UpdateCall node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BooleanExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TSEqualCall node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BooleanExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(PrimaryExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(Literal node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ValueExpression)node);
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(IntegerLiteral node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((Literal)node);
                this.Visit((ValueExpression)node);
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(NumericLiteral node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((Literal)node);
                this.Visit((ValueExpression)node);
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RealLiteral node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((Literal)node);
                this.Visit((ValueExpression)node);
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(MoneyLiteral node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((Literal)node);
                this.Visit((ValueExpression)node);
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BinaryLiteral node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((Literal)node);
                this.Visit((ValueExpression)node);
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(StringLiteral node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((Literal)node);
                this.Visit((ValueExpression)node);
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(NullLiteral node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((Literal)node);
                this.Visit((ValueExpression)node);
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(IdentifierLiteral node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((Literal)node);
                this.Visit((ValueExpression)node);
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DefaultLiteral node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((Literal)node);
                this.Visit((ValueExpression)node);
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(MaxLiteral node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((Literal)node);
                this.Visit((ValueExpression)node);
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OdbcLiteral node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((Literal)node);
                this.Visit((ValueExpression)node);
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(LiteralRange node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ValueExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(VariableReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ValueExpression)node);
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OptionValue node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OnOffOptionValue node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((OptionValue)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(LiteralOptionValue node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((OptionValue)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(GlobalVariableExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ValueExpression)node);
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(IdentifierOrValueExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(IdentifierOrScalarExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SchemaObjectNameOrValueExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ParenthesisExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ColumnReferenceExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(NextValueForExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PrimaryExpression)node);
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SequenceStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SequenceOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DataTypeSequenceOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SequenceOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ScalarExpressionSequenceOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SequenceOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateSequenceStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SequenceStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterSequenceStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SequenceStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropSequenceStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropObjectsStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SecurityPolicyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SecurityPredicateAction node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SecurityPolicyOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateSecurityPolicyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SecurityPolicyStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterSecurityPolicyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SecurityPolicyStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropSecurityPolicyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropObjectsStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateColumnMasterKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ColumnMasterKeyParameter node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ColumnMasterKeyStoreProviderNameParameter node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ColumnMasterKeyParameter)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ColumnMasterKeyPathParameter node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ColumnMasterKeyParameter)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropColumnMasterKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ColumnEncryptionKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateColumnEncryptionKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ColumnEncryptionKeyStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterColumnEncryptionKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ColumnEncryptionKeyStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropColumnEncryptionKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ColumnEncryptionKeyValue node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ColumnEncryptionKeyValueParameter node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ColumnMasterKeyNameParameter node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ColumnEncryptionKeyValueParameter)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ColumnEncryptionAlgorithmNameParameter node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ColumnEncryptionKeyValueParameter)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(EncryptedValueParameter node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ColumnEncryptionKeyValueParameter)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExternalTableStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExternalTableOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExternalTableLiteralOrIdentifierOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ExternalTableOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExternalTableDistributionOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ExternalTableOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExternalTableRejectTypeOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ExternalTableOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExternalTableDistributionPolicy node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExternalTableReplicatedDistributionPolicy node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ExternalTableDistributionPolicy)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExternalTableRoundRobinDistributionPolicy node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ExternalTableDistributionPolicy)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExternalTableShardedDistributionPolicy node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ExternalTableDistributionPolicy)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateExternalTableStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ExternalTableStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropExternalTableStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropObjectsStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExternalDataSourceStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExternalDataSourceOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExternalDataSourceLiteralOrIdentifierOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ExternalDataSourceOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateExternalDataSourceStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ExternalDataSourceStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterExternalDataSourceStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ExternalDataSourceStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropExternalDataSourceStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExternalFileFormatStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExternalFileFormatOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExternalFileFormatLiteralOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ExternalFileFormatOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExternalFileFormatUseDefaultTypeOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ExternalFileFormatOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExternalFileFormatContainerOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ExternalFileFormatOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateExternalFileFormatStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ExternalFileFormatStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropExternalFileFormatStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AssemblyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateAssemblyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AssemblyStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterAssemblyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AssemblyStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AssemblyOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OnOffAssemblyOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AssemblyOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(PermissionSetAssemblyOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AssemblyOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AddFileSpec node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateXmlSchemaCollectionStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterXmlSchemaCollectionStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropXmlSchemaCollectionStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AssemblyName node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterTableStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterTableAlterPartitionStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterTableStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterTableRebuildStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterTableStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterTableChangeTrackingModificationStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterTableStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterTableFileTableNamespaceStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterTableStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterTableSetStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterTableStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TableOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(LockEscalationTableOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FileStreamOnTableOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FileTableDirectoryTableOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FileTableCollateFileNameTableOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FileTableConstraintNameTableOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(MemoryOptimizedTableOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DurabilityTableOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RemoteDataArchiveTableOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RemoteDataArchiveAlterTableOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RemoteDataArchiveDatabaseOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DatabaseOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RemoteDataArchiveDatabaseSetting node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RemoteDataArchiveDbServerSetting node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((RemoteDataArchiveDatabaseSetting)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RemoteDataArchiveDbCredentialSetting node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((RemoteDataArchiveDatabaseSetting)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RemoteDataArchiveDbFederatedServiceAccountSetting node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((RemoteDataArchiveDatabaseSetting)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RetentionPeriodDefinition node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SystemVersioningTableOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterTableAddTableElementStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterTableStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterTableConstraintModificationStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterTableStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterTableSwitchStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterTableStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TableSwitchOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(LowPriorityLockWaitTableSwitchOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableSwitchOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropClusteredConstraintOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropClusteredConstraintStateOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropClusteredConstraintOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropClusteredConstraintValueOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropClusteredConstraintOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropClusteredConstraintMoveOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropClusteredConstraintOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropClusteredConstraintWaitAtLowPriorityLockOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropClusteredConstraintOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterTableDropTableElement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterTableDropTableElementStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterTableStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterTableTriggerModificationStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterTableStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(EnableDisableTriggerStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TryCatchStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateTypeStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateTypeUdtStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((CreateTypeStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateTypeUddtStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((CreateTypeStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateSynonymStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExecuteAsClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(QueueOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(QueueStateOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((QueueOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(QueueProcedureOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((QueueOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(QueueValueOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((QueueOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(QueueExecuteAsOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((QueueOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RouteOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RouteStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterRouteStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((RouteStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateRouteStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((RouteStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(QueueStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterQueueStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((QueueStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateQueueStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((QueueStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(IndexDefinition node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SystemTimePeriodDefinition node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(IndexStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(IndexType node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(PartitionSpecifier node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterIndexStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((IndexStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateXmlIndexStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((IndexStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateSelectiveXmlIndexStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((IndexStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FileGroupOrPartitionScheme node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateIndexStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((IndexStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(IndexOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(IndexStateOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((IndexOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(IndexExpressionOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((IndexOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(MaxDurationOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((IndexOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(WaitAtLowPriorityOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((IndexOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OnlineIndexOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((IndexStateOption)node);
                this.Visit((IndexOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(IgnoreDupKeyIndexOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((IndexStateOption)node);
                this.Visit((IndexOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OrderIndexOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((IndexOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OnlineIndexLowPriorityLockWaitOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(LowPriorityLockWaitOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(LowPriorityLockWaitMaxDurationOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((LowPriorityLockWaitOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(LowPriorityLockWaitAbortAfterWaitOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((LowPriorityLockWaitOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FullTextIndexColumn node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateFullTextIndexStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FullTextIndexOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ChangeTrackingFullTextIndexOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((FullTextIndexOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(StopListFullTextIndexOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((FullTextIndexOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SearchPropertyListFullTextIndexOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((FullTextIndexOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FullTextCatalogAndFileGroup node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(EventTypeGroupContainer node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(EventTypeContainer node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((EventTypeGroupContainer)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(EventGroupContainer node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((EventTypeGroupContainer)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateEventNotificationStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(EventNotificationObjectScope node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(MasterKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateMasterKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((MasterKeyStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterMasterKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((MasterKeyStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ApplicationRoleOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ApplicationRoleStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateApplicationRoleStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ApplicationRoleStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterApplicationRoleStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ApplicationRoleStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RoleStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateRoleStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((RoleStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterRoleStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((RoleStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterRoleAction node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RenameAlterRoleAction node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterRoleAction)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AddMemberAlterRoleAction node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterRoleAction)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropMemberAlterRoleAction node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterRoleAction)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateServerRoleStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((CreateRoleStatement)node);
                this.Visit((RoleStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterServerRoleStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterRoleStatement)node);
                this.Visit((RoleStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropServerRoleStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(UserLoginOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(UserStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateUserStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((UserStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterUserStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((UserStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(StatisticsOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ResampleStatisticsOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((StatisticsOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(StatisticsPartitionRange node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OnOffStatisticsOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((StatisticsOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(LiteralStatisticsOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((StatisticsOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateStatisticsStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(UpdateStatisticsStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ReturnStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DeclareCursorStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CursorDefinition node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CursorOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SetVariableStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CursorId node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CursorStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OpenCursorStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((CursorStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CloseCursorStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((CursorStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CryptoMechanism node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OpenSymmetricKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CloseSymmetricKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OpenMasterKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CloseMasterKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DeallocateCursorStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((CursorStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FetchType node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FetchCursorStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((CursorStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(WhereClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropUnownedObjectStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropObjectsStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropDatabaseStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropChildObjectsStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropIndexStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropIndexClauseBase node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BackwardsCompatibleDropIndexClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropIndexClauseBase)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropIndexClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropIndexClauseBase)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(MoveToDropIndexOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((IndexOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FileStreamOnDropIndexOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((IndexOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropStatisticsStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropChildObjectsStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropTableStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropObjectsStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropProcedureStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropObjectsStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropFunctionStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropObjectsStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropViewStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropObjectsStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropDefaultStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropObjectsStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropRuleStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropObjectsStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropTriggerStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropObjectsStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropSchemaStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RaiseErrorLegacyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RaiseErrorStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ThrowStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(UseStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(KillStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(KillQueryNotificationSubscriptionStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(KillStatsJobStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CheckpointStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ReconfigureStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ShutdownStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SetUserStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TruncateTableStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SetOnOffStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(PredicateSetStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SetOnOffStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SetStatisticsStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SetOnOffStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SetRowCountStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SetOffsetsStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SetOnOffStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SetCommand node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(GeneralSetCommand node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SetCommand)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SetFipsFlaggerCommand node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SetCommand)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SetCommandStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SetTransactionIsolationLevelStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SetTextSizeStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SetIdentityInsertStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SetOnOffStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SetErrorLevelStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateDatabaseStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FileDeclaration node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FileDeclarationOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(NameFileDeclarationOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((FileDeclarationOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FileNameFileDeclarationOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((FileDeclarationOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SizeFileDeclarationOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((FileDeclarationOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(MaxSizeFileDeclarationOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((FileDeclarationOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FileGrowthFileDeclarationOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((FileDeclarationOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FileGroupDefinition node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterDatabaseStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterDatabaseScopedConfigurationStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterDatabaseScopedConfigurationSetStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterDatabaseScopedConfigurationStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterDatabaseScopedConfigurationClearStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterDatabaseScopedConfigurationStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DatabaseConfigurationClearOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DatabaseConfigurationSetOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OnOffPrimaryConfigurationOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DatabaseConfigurationSetOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(MaxDopConfigurationOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DatabaseConfigurationSetOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(GenericConfigurationOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DatabaseConfigurationSetOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterDatabaseCollateStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterDatabaseStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterDatabaseRebuildLogStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterDatabaseStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterDatabaseAddFileStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterDatabaseStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterDatabaseAddFileGroupStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterDatabaseStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterDatabaseRemoveFileGroupStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterDatabaseStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterDatabaseRemoveFileStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterDatabaseStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterDatabaseModifyNameStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterDatabaseStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterDatabaseModifyFileStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterDatabaseStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterDatabaseModifyFileGroupStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterDatabaseStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterDatabaseTermination node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterDatabaseSetStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterDatabaseStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DatabaseOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OnOffDatabaseOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DatabaseOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AutoCreateStatisticsDatabaseOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((OnOffDatabaseOption)node);
                this.Visit((DatabaseOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ContainmentDatabaseOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DatabaseOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(HadrDatabaseOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DatabaseOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(HadrAvailabilityGroupDatabaseOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((HadrDatabaseOption)node);
                this.Visit((DatabaseOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DelayedDurabilityDatabaseOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DatabaseOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CursorDefaultDatabaseOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DatabaseOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RecoveryDatabaseOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DatabaseOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TargetRecoveryTimeDatabaseOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DatabaseOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(PageVerifyDatabaseOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DatabaseOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(PartnerDatabaseOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DatabaseOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(WitnessDatabaseOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DatabaseOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ParameterizationDatabaseOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DatabaseOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(LiteralDatabaseOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DatabaseOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(IdentifierDatabaseOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DatabaseOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ChangeTrackingDatabaseOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DatabaseOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ChangeTrackingOptionDetail node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AutoCleanupChangeTrackingOptionDetail node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ChangeTrackingOptionDetail)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ChangeRetentionChangeTrackingOptionDetail node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ChangeTrackingOptionDetail)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(QueryStoreDatabaseOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DatabaseOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(QueryStoreOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(QueryStoreDesiredStateOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((QueryStoreOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(QueryStoreCapturePolicyOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((QueryStoreOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(QueryStoreSizeCleanupPolicyOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((QueryStoreOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(QueryStoreDataFlushIntervalOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((QueryStoreOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(QueryStoreIntervalLengthOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((QueryStoreOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(QueryStoreMaxStorageSizeOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((QueryStoreOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(QueryStoreMaxPlansPerQueryOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((QueryStoreOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(QueryStoreTimeCleanupPolicyOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((QueryStoreOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FileStreamDatabaseOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DatabaseOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(MaxSizeDatabaseOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DatabaseOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterTableAlterIndexStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterTableStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterTableAlterColumnStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterTableStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ColumnDefinition node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ColumnDefinitionBase)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ColumnEncryptionDefinition node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ColumnEncryptionDefinitionParameter node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ColumnEncryptionKeyNameParameter node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ColumnEncryptionDefinitionParameter)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ColumnEncryptionTypeParameter node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ColumnEncryptionDefinitionParameter)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ColumnEncryptionAlgorithmParameter node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ColumnEncryptionDefinitionParameter)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(IdentityOptions node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ColumnStorageOptions node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ConstraintDefinition node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateTableStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FederationScheme node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TableDataCompressionOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TableDistributionOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TableDistributionPolicy node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TableReplicateDistributionPolicy node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableDistributionPolicy)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TableRoundRobinDistributionPolicy node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableDistributionPolicy)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TableHashDistributionPolicy node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableDistributionPolicy)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TableIndexOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TableIndexType node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TableClusteredIndexType node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableIndexType)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TableNonClusteredIndexType node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableIndexType)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TablePartitionOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(PartitionSpecifications node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TablePartitionOptionSpecifications node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PartitionSpecifications)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DataCompressionOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((IndexOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CompressionPartitionRange node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CheckConstraintDefinition node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ConstraintDefinition)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DefaultConstraintDefinition node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ConstraintDefinition)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ForeignKeyConstraintDefinition node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ConstraintDefinition)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(NullableConstraintDefinition node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ConstraintDefinition)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(UniqueConstraintDefinition node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ConstraintDefinition)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BackupStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BackupDatabaseStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BackupStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BackupTransactionLogStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BackupStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RestoreStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RestoreOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ScalarExpressionRestoreOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((RestoreOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(MoveRestoreOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((RestoreOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(StopRestoreOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((RestoreOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FileStreamRestoreOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((RestoreOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BackupOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BackupEncryptionOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BackupOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DeviceInfo node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(MirrorToClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BackupRestoreFileInfo node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BulkInsertBase node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BulkInsertStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BulkInsertBase)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(InsertBulkStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BulkInsertBase)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BulkInsertOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(LiteralBulkInsertOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BulkInsertOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OrderBulkInsertOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BulkInsertOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ColumnDefinitionBase node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExternalTableColumnDefinition node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(InsertBulkColumnDefinition node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DbccStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DbccOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DbccNamedLiteral node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateAsymmetricKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreatePartitionFunctionStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(PartitionParameterType node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreatePartitionSchemeStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RemoteServiceBindingStatementBase node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RemoteServiceBindingOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OnOffRemoteServiceBindingOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((RemoteServiceBindingOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(UserRemoteServiceBindingOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((RemoteServiceBindingOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateRemoteServiceBindingStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((RemoteServiceBindingStatementBase)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterRemoteServiceBindingStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((RemoteServiceBindingStatementBase)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(EncryptionSource node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AssemblyEncryptionSource node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((EncryptionSource)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FileEncryptionSource node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((EncryptionSource)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ProviderEncryptionSource node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((EncryptionSource)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CertificateStatementBase node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterCertificateStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((CertificateStatementBase)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateCertificateStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((CertificateStatementBase)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CertificateOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateContractStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ContractMessage node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CredentialStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateCredentialStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((CredentialStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterCredentialStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((CredentialStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(MessageTypeStatementBase node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateMessageTypeStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((MessageTypeStatementBase)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterMessageTypeStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((MessageTypeStatementBase)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateAggregateStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateEndpointStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterCreateEndpointStatementBase)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterEndpointStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterCreateEndpointStatementBase)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterCreateEndpointStatementBase node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(EndpointAffinity node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(EndpointProtocolOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(LiteralEndpointProtocolOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((EndpointProtocolOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AuthenticationEndpointProtocolOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((EndpointProtocolOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(PortsEndpointProtocolOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((EndpointProtocolOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CompressionEndpointProtocolOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((EndpointProtocolOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ListenerIPEndpointProtocolOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((EndpointProtocolOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(IPv4 node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SoapMethod node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PayloadOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(PayloadOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(EnabledDisabledPayloadOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PayloadOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(WsdlPayloadOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PayloadOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(LoginTypePayloadOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PayloadOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(LiteralPayloadOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PayloadOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SessionTimeoutPayloadOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PayloadOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SchemaPayloadOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PayloadOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CharacterSetPayloadOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PayloadOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RolePayloadOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PayloadOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AuthenticationPayloadOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PayloadOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(EncryptionPayloadOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PayloadOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SymmetricKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateSymmetricKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SymmetricKeyStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(KeyOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(KeySourceKeyOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((KeyOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlgorithmKeyOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((KeyOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(IdentityValueKeyOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((KeyOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ProviderKeyNameKeyOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((KeyOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreationDispositionKeyOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((KeyOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterSymmetricKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SymmetricKeyStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FullTextCatalogStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FullTextCatalogOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OnOffFullTextCatalogOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((FullTextCatalogOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateFullTextCatalogStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((FullTextCatalogStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterFullTextCatalogStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((FullTextCatalogStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterCreateServiceStatementBase node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateServiceStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterCreateServiceStatementBase)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterServiceStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterCreateServiceStatementBase)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ServiceContract node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BinaryExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BuiltInFunctionTableReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableReferenceWithAlias)node);
                this.Visit((TableReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(GlobalFunctionTableReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableReferenceWithAlias)node);
                this.Visit((TableReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ComputeClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ComputeFunction node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(PivotedTableReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableReferenceWithAlias)node);
                this.Visit((TableReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(UnpivotedTableReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableReferenceWithAlias)node);
                this.Visit((TableReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(UnqualifiedJoin node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((JoinTableReference)node);
                this.Visit((TableReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TableSampleClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ScalarExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BooleanExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BooleanNotExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BooleanExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BooleanParenthesisExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BooleanExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BooleanComparisonExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BooleanExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BooleanBinaryExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BooleanExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BooleanIsNullExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BooleanExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(GraphMatchPredicate node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BooleanExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(GraphMatchExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BooleanExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExpressionWithSortOrder node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(GroupByClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(GroupingSpecification node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExpressionGroupingSpecification node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((GroupingSpecification)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CompositeGroupingSpecification node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((GroupingSpecification)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CubeGroupingSpecification node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((GroupingSpecification)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RollupGroupingSpecification node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((GroupingSpecification)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(GrandTotalGroupingSpecification node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((GroupingSpecification)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(GroupingSetsGroupingSpecification node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((GroupingSpecification)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OutputClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OutputIntoClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(HavingClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(IdentityFunctionCall node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(JoinParenthesisTableReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OrderByClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(JoinTableReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(QualifiedJoin node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((JoinTableReference)node);
                this.Visit((TableReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OdbcQualifiedJoinTableReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(QueryExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(QueryParenthesisExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((QueryExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(QuerySpecification node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((QueryExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FromClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SelectElement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SelectScalarExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SelectElement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SelectStarExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SelectElement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SelectSetVariable node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SelectElement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TableReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TableReferenceWithAlias node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TableReferenceWithAliasAndColumns node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableReferenceWithAlias)node);
                this.Visit((TableReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DataModificationTableReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableReferenceWithAliasAndColumns)node);
                this.Visit((TableReferenceWithAlias)node);
                this.Visit((TableReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ChangeTableChangesTableReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableReferenceWithAliasAndColumns)node);
                this.Visit((TableReferenceWithAlias)node);
                this.Visit((TableReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ChangeTableVersionTableReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableReferenceWithAliasAndColumns)node);
                this.Visit((TableReferenceWithAlias)node);
                this.Visit((TableReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BooleanTernaryExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BooleanExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TopRowFilter node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OffsetClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(UnaryExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BinaryQueryExpression node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((QueryExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(VariableTableReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableReferenceWithAlias)node);
                this.Visit((TableReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(VariableMethodCallTableReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TableReferenceWithAliasAndColumns)node);
                this.Visit((TableReferenceWithAlias)node);
                this.Visit((TableReference)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropPartitionFunctionStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropPartitionSchemeStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropSynonymStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropObjectsStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropAggregateStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropObjectsStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropAssemblyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropObjectsStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropApplicationRoleStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropFullTextCatalogStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropFullTextIndexStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropLoginStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropRoleStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropTypeStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropUserStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropMasterKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropSymmetricKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropAsymmetricKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropCertificateStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropCredentialStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterPartitionFunctionStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterPartitionSchemeStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterFullTextIndexStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterFullTextIndexAction node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SimpleAlterFullTextIndexAction node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterFullTextIndexAction)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SetStopListAlterFullTextIndexAction node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterFullTextIndexAction)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SetSearchPropertyListAlterFullTextIndexAction node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterFullTextIndexAction)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropAlterFullTextIndexAction node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterFullTextIndexAction)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AddAlterFullTextIndexAction node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterFullTextIndexAction)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterColumnAlterFullTextIndexAction node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterFullTextIndexAction)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateSearchPropertyListStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterSearchPropertyListStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SearchPropertyListAction node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AddSearchPropertyListAction node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SearchPropertyListAction)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropSearchPropertyListAction node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SearchPropertyListAction)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropSearchPropertyListStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateLoginStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateLoginSource node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(PasswordCreateLoginSource node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((CreateLoginSource)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(PrincipalOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OnOffPrincipalOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PrincipalOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(LiteralPrincipalOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PrincipalOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(IdentifierPrincipalOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PrincipalOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(WindowsCreateLoginSource node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((CreateLoginSource)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CertificateCreateLoginSource node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((CreateLoginSource)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AsymmetricKeyCreateLoginSource node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((CreateLoginSource)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(PasswordAlterPrincipalOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((PrincipalOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterLoginStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterLoginOptionsStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterLoginStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterLoginEnableDisableStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterLoginStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterLoginAddDropCredentialStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterLoginStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RevertStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropContractStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropEndpointStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropMessageTypeStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropQueueStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropRemoteServiceBindingStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropRouteStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropServiceStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SignatureStatementBase node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AddSignatureStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SignatureStatementBase)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropSignatureStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SignatureStatementBase)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropEventNotificationStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExecuteAsStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(EndConversationStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(MoveConversationStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(GetConversationGroupStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((WaitForSupportedStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ReceiveStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((WaitForSupportedStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SendStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(WaitForSupportedStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterSchemaStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterAsymmetricKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterServiceMasterKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BeginConversationTimerStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BeginDialogStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DialogOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ScalarExpressionDialogOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DialogOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OnOffDialogOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DialogOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BackupCertificateStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((CertificateStatementBase)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BackupRestoreMasterKeyStatementBase node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BackupServiceMasterKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BackupRestoreMasterKeyStatementBase)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RestoreServiceMasterKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BackupRestoreMasterKeyStatementBase)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BackupMasterKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BackupRestoreMasterKeyStatementBase)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(RestoreMasterKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BackupRestoreMasterKeyStatementBase)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ScalarExpressionSnippet node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BooleanExpressionSnippet node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BooleanExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(StatementListSnippet node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((StatementList)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SelectStatementSnippet node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SelectStatement)node);
                this.Visit((StatementWithCtesAndXmlNamespaces)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SchemaObjectNameSnippet node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SchemaObjectName)node);
                this.Visit((MultiPartIdentifier)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TSqlFragmentSnippet node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TSqlStatementSnippet node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(IdentifierSnippet node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((Identifier)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TSqlScript node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TSqlBatch node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TSqlStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DataModificationStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((StatementWithCtesAndXmlNamespaces)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DataModificationSpecification node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(MergeStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DataModificationStatement)node);
                this.Visit((StatementWithCtesAndXmlNamespaces)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(MergeSpecification node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DataModificationSpecification)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(MergeActionClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(MergeAction node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(UpdateMergeAction node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((MergeAction)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DeleteMergeAction node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((MergeAction)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(InsertMergeAction node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((MergeAction)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateTypeTableStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((CreateTypeStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AuditSpecificationStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AuditSpecificationPart node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AuditSpecificationDetail node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AuditActionSpecification node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AuditSpecificationDetail)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DatabaseAuditAction node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AuditActionGroupReference node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AuditSpecificationDetail)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateDatabaseAuditSpecificationStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AuditSpecificationStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterDatabaseAuditSpecificationStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AuditSpecificationStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropDatabaseAuditSpecificationStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateServerAuditSpecificationStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AuditSpecificationStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterServerAuditSpecificationStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AuditSpecificationStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropServerAuditSpecificationStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ServerAuditStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateServerAuditStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ServerAuditStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterServerAuditStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ServerAuditStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropServerAuditStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AuditTarget node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AuditOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(QueueDelayAuditOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AuditOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AuditGuidAuditOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AuditOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OnFailureAuditOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AuditOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(StateAuditOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AuditOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AuditTargetOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(MaxSizeAuditTargetOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AuditTargetOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(MaxRolloverFilesAuditTargetOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AuditTargetOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(LiteralAuditTargetOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AuditTargetOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OnOffAuditTargetOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AuditTargetOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DatabaseEncryptionKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateDatabaseEncryptionKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DatabaseEncryptionKeyStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterDatabaseEncryptionKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DatabaseEncryptionKeyStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropDatabaseEncryptionKeyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ResourcePoolStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ResourcePoolParameter node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ResourcePoolAffinitySpecification node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateResourcePoolStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ResourcePoolStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterResourcePoolStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ResourcePoolStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropResourcePoolStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExternalResourcePoolStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExternalResourcePoolParameter node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ExternalResourcePoolAffinitySpecification node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateExternalResourcePoolStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ExternalResourcePoolStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterExternalResourcePoolStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ExternalResourcePoolStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropExternalResourcePoolStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(WorkloadGroupStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(WorkloadGroupResourceParameter node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((WorkloadGroupParameter)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(WorkloadGroupImportanceParameter node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((WorkloadGroupParameter)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(WorkloadGroupParameter node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateWorkloadGroupStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((WorkloadGroupStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterWorkloadGroupStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((WorkloadGroupStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropWorkloadGroupStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BrokerPriorityStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BrokerPriorityParameter node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateBrokerPriorityStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BrokerPriorityStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterBrokerPriorityStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BrokerPriorityStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropBrokerPriorityStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateFullTextStopListStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterFullTextStopListStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FullTextStopListAction node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropFullTextStopListStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateCryptographicProviderStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterCryptographicProviderStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropCryptographicProviderStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(EventSessionObjectName node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(EventSessionStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateEventSessionStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((EventSessionStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(EventDeclaration node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(EventDeclarationSetParameter node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SourceDeclaration node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((ScalarExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(EventDeclarationCompareFunctionParameter node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((BooleanExpression)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TargetDeclaration node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SessionOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(EventRetentionSessionOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SessionOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(MemoryPartitionSessionOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SessionOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(LiteralSessionOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SessionOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(MaxDispatchLatencySessionOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SessionOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(OnOffSessionOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SessionOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterEventSessionStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((EventSessionStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropEventSessionStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterResourceGovernorStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateSpatialIndexStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SpatialIndexOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SpatialIndexRegularOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SpatialIndexOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BoundingBoxSpatialIndexOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SpatialIndexOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(BoundingBoxParameter node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(GridsSpatialIndexOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SpatialIndexOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(GridParameter node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CellsPerObjectSpatialIndexOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((SpatialIndexOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterServerConfigurationStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(ProcessAffinityRange node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((LiteralRange)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterServerConfigurationSetBufferPoolExtensionStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterServerConfigurationBufferPoolExtensionOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterServerConfigurationBufferPoolExtensionContainerOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterServerConfigurationBufferPoolExtensionOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterServerConfigurationBufferPoolExtensionSizeOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterServerConfigurationBufferPoolExtensionOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterServerConfigurationSetDiagnosticsLogStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterServerConfigurationDiagnosticsLogOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterServerConfigurationDiagnosticsLogMaxSizeOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterServerConfigurationDiagnosticsLogOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterServerConfigurationSetFailoverClusterPropertyStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterServerConfigurationFailoverClusterPropertyOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterServerConfigurationSetHadrClusterStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterServerConfigurationHadrClusterOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterServerConfigurationSetSoftNumaStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterServerConfigurationSoftNumaOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AvailabilityGroupStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateAvailabilityGroupStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AvailabilityGroupStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterAvailabilityGroupStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AvailabilityGroupStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AvailabilityReplica node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AvailabilityReplicaOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(LiteralReplicaOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AvailabilityReplicaOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AvailabilityModeReplicaOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AvailabilityReplicaOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(FailoverModeReplicaOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AvailabilityReplicaOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(PrimaryRoleReplicaOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AvailabilityReplicaOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SecondaryRoleReplicaOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AvailabilityReplicaOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AvailabilityGroupOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(LiteralAvailabilityGroupOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AvailabilityGroupOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterAvailabilityGroupAction node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterAvailabilityGroupFailoverAction node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((AlterAvailabilityGroupAction)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterAvailabilityGroupFailoverOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropAvailabilityGroupStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateFederationStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(AlterFederationStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DropFederationStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((DropUnownedObjectStatement)node);
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(UseFederationStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DiskStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(DiskStatementOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CreateColumnStoreIndexStatement node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlStatement)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(WindowFrameClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(WindowDelimiter node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(WithinGroupClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(SelectiveXmlIndexPromotedPath node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(TemporalClause node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void ExplicitVisit(CompressionDelayIndexOption node)
        {
            if (this.VisitBaseType)
            {
                this.Visit((IndexOption)node);
                this.Visit((TSqlFragment)node);
            }
            this.Visit(node);
            node.AcceptChildren(this);
        }

        public virtual void Visit(TSqlFragment fragment)
        {
        }

        public virtual void Visit(StatementList node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExecuteStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExecuteOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ResultSetsExecuteOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ResultSetDefinition node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(InlineResultSetDefinition node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ResultColumnDefinition node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SchemaObjectResultSetDefinition node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExecuteSpecification node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExecuteContext node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExecuteParameter node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExecutableEntity node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ProcedureReferenceName node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExecutableProcedureReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExecutableStringList node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AdHocDataSource node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ViewOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterViewStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateViewStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateOrAlterViewStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ViewStatementBody node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TriggerObject node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TriggerOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExecuteAsTriggerOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TriggerAction node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterTriggerStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateTriggerStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateOrAlterTriggerStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TriggerStatementBody node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(Identifier node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterProcedureStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateProcedureStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateOrAlterProcedureStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ProcedureReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(MethodSpecifier node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ProcedureStatementBody node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ProcedureStatementBodyBase node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FunctionStatementBody node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ProcedureOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExecuteAsProcedureOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FunctionOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExecuteAsFunctionOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(XmlNamespaces node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(XmlNamespacesElement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(XmlNamespacesDefaultElement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(XmlNamespacesAliasElement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CommonTableExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(WithCtesAndXmlNamespaces node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FunctionReturnType node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TableValuedFunctionReturnType node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DataTypeReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ParameterizedDataTypeReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SqlDataTypeReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(UserDataTypeReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(XmlDataTypeReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ScalarFunctionReturnType node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SelectFunctionReturnType node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TableDefinition node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DeclareTableVariableBody node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DeclareTableVariableStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(NamedTableReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SchemaObjectFunctionTableReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TableHint node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(IndexTableHint node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(LiteralTableHint node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(QueryDerivedTable node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(InlineDerivedTable node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SubqueryComparisonPredicate node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExistsPredicate node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(LikePredicate node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(InPredicate node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FullTextPredicate node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(UserDefinedTypePropertyAccess node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(StatementWithCtesAndXmlNamespaces node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SelectStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ForClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BrowseForClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ReadOnlyForClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(XmlForClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(XmlForClauseOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(JsonForClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(JsonForClauseOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(UpdateForClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OptimizerHint node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(LiteralOptimizerHint node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TableHintsOptimizerHint node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ForceSeekTableHint node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OptimizeForOptimizerHint node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(UseHintList node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(VariableValuePair node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(WhenClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SimpleWhenClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SearchedWhenClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CaseExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SimpleCaseExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SearchedCaseExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(NullIfExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CoalesceExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(IIfCall node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FullTextTableReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SemanticTableReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OpenXmlTableReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OpenJsonTableReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OpenRowsetTableReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(InternalOpenRowset node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BulkOpenRowset node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OpenQueryTableReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AdHocTableReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SchemaDeclarationItem node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SchemaDeclarationItemOpenjson node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ConvertCall node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TryConvertCall node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ParseCall node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TryParseCall node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CastCall node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TryCastCall node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AtTimeZoneCall node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FunctionCall node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CallTarget node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExpressionCallTarget node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(MultiPartIdentifierCallTarget node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(UserDefinedTypeCallTarget node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(LeftFunctionCall node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RightFunctionCall node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(PartitionFunctionCall node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OverClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ParameterlessCall node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ScalarSubquery node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OdbcFunctionCall node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExtractFromExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OdbcConvertSpecification node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterFunctionStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BeginEndBlockStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BeginEndAtomicBlockStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AtomicBlockOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(LiteralAtomicBlockOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(IdentifierAtomicBlockOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OnOffAtomicBlockOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BeginTransactionStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BreakStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ColumnWithSortOrder node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CommitTransactionStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RollbackTransactionStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SaveTransactionStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ContinueStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateDefaultStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateFunctionStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateOrAlterFunctionStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateRuleStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DeclareVariableElement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DeclareVariableStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(GoToStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(IfStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(LabelStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(MultiPartIdentifier node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SchemaObjectName node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ChildObjectName node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ProcedureParameter node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TransactionStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(WhileStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DeleteStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(UpdateDeleteSpecificationBase node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DeleteSpecification node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(InsertStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(InsertSpecification node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(UpdateStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(UpdateSpecification node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateSchemaStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(WaitForStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ReadTextStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(UpdateTextStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(WriteTextStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TextModificationStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(LineNoStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SecurityStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(GrantStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DenyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RevokeStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterAuthorizationStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(Permission node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SecurityTargetObject node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SecurityTargetObjectName node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SecurityPrincipal node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SecurityStatementBody80 node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(GrantStatement80 node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DenyStatement80 node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RevokeStatement80 node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SecurityElement80 node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CommandSecurityElement80 node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(PrivilegeSecurityElement80 node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(Privilege80 node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SecurityUserClause80 node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SqlCommandIdentifier node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SetClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AssignmentSetClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FunctionCallSetClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(InsertSource node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ValuesInsertSource node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SelectInsertSource node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExecuteInsertSource node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RowValue node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(PrintStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(UpdateCall node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TSEqualCall node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(PrimaryExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(Literal node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(IntegerLiteral node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(NumericLiteral node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RealLiteral node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(MoneyLiteral node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BinaryLiteral node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(StringLiteral node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(NullLiteral node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(IdentifierLiteral node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DefaultLiteral node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(MaxLiteral node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OdbcLiteral node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(LiteralRange node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ValueExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(VariableReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OptionValue node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OnOffOptionValue node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(LiteralOptionValue node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(GlobalVariableExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(IdentifierOrValueExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(IdentifierOrScalarExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SchemaObjectNameOrValueExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ParenthesisExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ColumnReferenceExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(NextValueForExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SequenceStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SequenceOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DataTypeSequenceOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ScalarExpressionSequenceOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateSequenceStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterSequenceStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropSequenceStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SecurityPolicyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SecurityPredicateAction node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SecurityPolicyOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateSecurityPolicyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterSecurityPolicyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropSecurityPolicyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateColumnMasterKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ColumnMasterKeyParameter node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ColumnMasterKeyStoreProviderNameParameter node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ColumnMasterKeyPathParameter node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropColumnMasterKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ColumnEncryptionKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateColumnEncryptionKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterColumnEncryptionKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropColumnEncryptionKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ColumnEncryptionKeyValue node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ColumnEncryptionKeyValueParameter node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ColumnMasterKeyNameParameter node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ColumnEncryptionAlgorithmNameParameter node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(EncryptedValueParameter node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExternalTableStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExternalTableOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExternalTableLiteralOrIdentifierOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExternalTableDistributionOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExternalTableRejectTypeOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExternalTableDistributionPolicy node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExternalTableReplicatedDistributionPolicy node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExternalTableRoundRobinDistributionPolicy node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExternalTableShardedDistributionPolicy node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateExternalTableStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropExternalTableStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExternalDataSourceStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExternalDataSourceOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExternalDataSourceLiteralOrIdentifierOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateExternalDataSourceStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterExternalDataSourceStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropExternalDataSourceStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExternalFileFormatStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExternalFileFormatOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExternalFileFormatLiteralOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExternalFileFormatUseDefaultTypeOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExternalFileFormatContainerOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateExternalFileFormatStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropExternalFileFormatStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AssemblyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateAssemblyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterAssemblyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AssemblyOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OnOffAssemblyOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(PermissionSetAssemblyOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AddFileSpec node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateXmlSchemaCollectionStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterXmlSchemaCollectionStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropXmlSchemaCollectionStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AssemblyName node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterTableStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterTableAlterPartitionStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterTableRebuildStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterTableChangeTrackingModificationStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterTableFileTableNamespaceStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterTableSetStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TableOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(LockEscalationTableOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FileStreamOnTableOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FileTableDirectoryTableOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FileTableCollateFileNameTableOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FileTableConstraintNameTableOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(MemoryOptimizedTableOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DurabilityTableOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RemoteDataArchiveTableOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RemoteDataArchiveAlterTableOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RemoteDataArchiveDatabaseOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RemoteDataArchiveDatabaseSetting node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RemoteDataArchiveDbServerSetting node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RemoteDataArchiveDbCredentialSetting node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RemoteDataArchiveDbFederatedServiceAccountSetting node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RetentionPeriodDefinition node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SystemVersioningTableOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterTableAddTableElementStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterTableConstraintModificationStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterTableSwitchStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TableSwitchOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(LowPriorityLockWaitTableSwitchOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropClusteredConstraintOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropClusteredConstraintStateOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropClusteredConstraintValueOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropClusteredConstraintMoveOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropClusteredConstraintWaitAtLowPriorityLockOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterTableDropTableElement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterTableDropTableElementStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterTableTriggerModificationStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(EnableDisableTriggerStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TryCatchStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateTypeStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateTypeUdtStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateTypeUddtStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateSynonymStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExecuteAsClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(QueueOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(QueueStateOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(QueueProcedureOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(QueueValueOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(QueueExecuteAsOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RouteOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RouteStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterRouteStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateRouteStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(QueueStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterQueueStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateQueueStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(IndexDefinition node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SystemTimePeriodDefinition node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(IndexStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(IndexType node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(PartitionSpecifier node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterIndexStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateXmlIndexStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateSelectiveXmlIndexStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FileGroupOrPartitionScheme node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateIndexStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(IndexOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(IndexStateOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(IndexExpressionOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(MaxDurationOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(WaitAtLowPriorityOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OnlineIndexOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(IgnoreDupKeyIndexOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OrderIndexOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OnlineIndexLowPriorityLockWaitOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(LowPriorityLockWaitOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(LowPriorityLockWaitMaxDurationOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(LowPriorityLockWaitAbortAfterWaitOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FullTextIndexColumn node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateFullTextIndexStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FullTextIndexOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ChangeTrackingFullTextIndexOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(StopListFullTextIndexOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SearchPropertyListFullTextIndexOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FullTextCatalogAndFileGroup node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(EventTypeGroupContainer node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(EventTypeContainer node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(EventGroupContainer node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateEventNotificationStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(EventNotificationObjectScope node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(MasterKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateMasterKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterMasterKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ApplicationRoleOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ApplicationRoleStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateApplicationRoleStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterApplicationRoleStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RoleStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateRoleStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterRoleStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterRoleAction node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RenameAlterRoleAction node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AddMemberAlterRoleAction node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropMemberAlterRoleAction node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateServerRoleStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterServerRoleStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropServerRoleStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(UserLoginOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(UserStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateUserStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterUserStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(StatisticsOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ResampleStatisticsOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(StatisticsPartitionRange node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OnOffStatisticsOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(LiteralStatisticsOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateStatisticsStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(UpdateStatisticsStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ReturnStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DeclareCursorStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CursorDefinition node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CursorOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SetVariableStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CursorId node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CursorStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OpenCursorStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CloseCursorStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CryptoMechanism node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OpenSymmetricKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CloseSymmetricKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OpenMasterKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CloseMasterKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DeallocateCursorStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FetchType node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FetchCursorStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(WhereClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropUnownedObjectStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropObjectsStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropDatabaseStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropChildObjectsStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropIndexStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropIndexClauseBase node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BackwardsCompatibleDropIndexClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropIndexClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(MoveToDropIndexOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FileStreamOnDropIndexOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropStatisticsStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropTableStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropProcedureStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropFunctionStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropViewStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropDefaultStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropRuleStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropTriggerStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropSchemaStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RaiseErrorLegacyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RaiseErrorStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ThrowStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(UseStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(KillStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(KillQueryNotificationSubscriptionStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(KillStatsJobStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CheckpointStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ReconfigureStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ShutdownStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SetUserStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TruncateTableStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SetOnOffStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(PredicateSetStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SetStatisticsStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SetRowCountStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SetOffsetsStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SetCommand node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(GeneralSetCommand node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SetFipsFlaggerCommand node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SetCommandStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SetTransactionIsolationLevelStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SetTextSizeStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SetIdentityInsertStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SetErrorLevelStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateDatabaseStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FileDeclaration node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FileDeclarationOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(NameFileDeclarationOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FileNameFileDeclarationOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SizeFileDeclarationOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(MaxSizeFileDeclarationOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FileGrowthFileDeclarationOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FileGroupDefinition node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterDatabaseStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterDatabaseScopedConfigurationStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterDatabaseScopedConfigurationSetStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterDatabaseScopedConfigurationClearStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DatabaseConfigurationClearOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DatabaseConfigurationSetOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OnOffPrimaryConfigurationOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(MaxDopConfigurationOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(GenericConfigurationOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterDatabaseCollateStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterDatabaseRebuildLogStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterDatabaseAddFileStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterDatabaseAddFileGroupStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterDatabaseRemoveFileGroupStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterDatabaseRemoveFileStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterDatabaseModifyNameStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterDatabaseModifyFileStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterDatabaseModifyFileGroupStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterDatabaseTermination node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterDatabaseSetStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DatabaseOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OnOffDatabaseOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AutoCreateStatisticsDatabaseOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ContainmentDatabaseOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(HadrDatabaseOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(HadrAvailabilityGroupDatabaseOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DelayedDurabilityDatabaseOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CursorDefaultDatabaseOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RecoveryDatabaseOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TargetRecoveryTimeDatabaseOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(PageVerifyDatabaseOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(PartnerDatabaseOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(WitnessDatabaseOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ParameterizationDatabaseOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(LiteralDatabaseOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(IdentifierDatabaseOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ChangeTrackingDatabaseOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ChangeTrackingOptionDetail node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AutoCleanupChangeTrackingOptionDetail node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ChangeRetentionChangeTrackingOptionDetail node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(QueryStoreDatabaseOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(QueryStoreOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(QueryStoreDesiredStateOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(QueryStoreCapturePolicyOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(QueryStoreSizeCleanupPolicyOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(QueryStoreDataFlushIntervalOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(QueryStoreIntervalLengthOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(QueryStoreMaxStorageSizeOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(QueryStoreMaxPlansPerQueryOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(QueryStoreTimeCleanupPolicyOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FileStreamDatabaseOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(MaxSizeDatabaseOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterTableAlterIndexStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterTableAlterColumnStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ColumnDefinition node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ColumnEncryptionDefinition node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ColumnEncryptionDefinitionParameter node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ColumnEncryptionKeyNameParameter node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ColumnEncryptionTypeParameter node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ColumnEncryptionAlgorithmParameter node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(IdentityOptions node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ColumnStorageOptions node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ConstraintDefinition node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateTableStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FederationScheme node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TableDataCompressionOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TableDistributionOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TableDistributionPolicy node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TableReplicateDistributionPolicy node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TableRoundRobinDistributionPolicy node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TableHashDistributionPolicy node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TableIndexOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TableIndexType node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TableClusteredIndexType node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TableNonClusteredIndexType node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TablePartitionOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(PartitionSpecifications node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TablePartitionOptionSpecifications node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DataCompressionOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CompressionPartitionRange node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CheckConstraintDefinition node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DefaultConstraintDefinition node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ForeignKeyConstraintDefinition node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(NullableConstraintDefinition node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(UniqueConstraintDefinition node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BackupStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BackupDatabaseStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BackupTransactionLogStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RestoreStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RestoreOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ScalarExpressionRestoreOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(MoveRestoreOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(StopRestoreOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FileStreamRestoreOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BackupOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BackupEncryptionOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DeviceInfo node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(MirrorToClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BackupRestoreFileInfo node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BulkInsertBase node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BulkInsertStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(InsertBulkStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BulkInsertOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(LiteralBulkInsertOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OrderBulkInsertOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ColumnDefinitionBase node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExternalTableColumnDefinition node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(InsertBulkColumnDefinition node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DbccStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DbccOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DbccNamedLiteral node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateAsymmetricKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreatePartitionFunctionStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(PartitionParameterType node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreatePartitionSchemeStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RemoteServiceBindingStatementBase node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RemoteServiceBindingOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OnOffRemoteServiceBindingOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(UserRemoteServiceBindingOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateRemoteServiceBindingStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterRemoteServiceBindingStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(EncryptionSource node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AssemblyEncryptionSource node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FileEncryptionSource node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ProviderEncryptionSource node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CertificateStatementBase node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterCertificateStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateCertificateStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CertificateOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateContractStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ContractMessage node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CredentialStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateCredentialStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterCredentialStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(MessageTypeStatementBase node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateMessageTypeStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterMessageTypeStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateAggregateStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateEndpointStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterEndpointStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterCreateEndpointStatementBase node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(EndpointAffinity node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(EndpointProtocolOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(LiteralEndpointProtocolOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AuthenticationEndpointProtocolOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(PortsEndpointProtocolOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CompressionEndpointProtocolOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ListenerIPEndpointProtocolOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(IPv4 node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SoapMethod node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(PayloadOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(EnabledDisabledPayloadOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(WsdlPayloadOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(LoginTypePayloadOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(LiteralPayloadOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SessionTimeoutPayloadOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SchemaPayloadOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CharacterSetPayloadOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RolePayloadOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AuthenticationPayloadOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(EncryptionPayloadOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SymmetricKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateSymmetricKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(KeyOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(KeySourceKeyOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlgorithmKeyOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(IdentityValueKeyOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ProviderKeyNameKeyOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreationDispositionKeyOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterSymmetricKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FullTextCatalogStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FullTextCatalogOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OnOffFullTextCatalogOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateFullTextCatalogStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterFullTextCatalogStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterCreateServiceStatementBase node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateServiceStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterServiceStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ServiceContract node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BinaryExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BuiltInFunctionTableReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(GlobalFunctionTableReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ComputeClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ComputeFunction node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(PivotedTableReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(UnpivotedTableReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(UnqualifiedJoin node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TableSampleClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ScalarExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BooleanExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BooleanNotExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BooleanParenthesisExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BooleanComparisonExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BooleanBinaryExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BooleanIsNullExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(GraphMatchPredicate node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(GraphMatchExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExpressionWithSortOrder node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(GroupByClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(GroupingSpecification node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExpressionGroupingSpecification node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CompositeGroupingSpecification node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CubeGroupingSpecification node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RollupGroupingSpecification node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(GrandTotalGroupingSpecification node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(GroupingSetsGroupingSpecification node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OutputClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OutputIntoClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(HavingClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(IdentityFunctionCall node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(JoinParenthesisTableReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OrderByClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(JoinTableReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(QualifiedJoin node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OdbcQualifiedJoinTableReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(QueryExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(QueryParenthesisExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(QuerySpecification node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FromClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SelectElement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SelectScalarExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SelectStarExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SelectSetVariable node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TableReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TableReferenceWithAlias node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TableReferenceWithAliasAndColumns node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DataModificationTableReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ChangeTableChangesTableReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ChangeTableVersionTableReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BooleanTernaryExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TopRowFilter node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OffsetClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(UnaryExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BinaryQueryExpression node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(VariableTableReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(VariableMethodCallTableReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropPartitionFunctionStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropPartitionSchemeStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropSynonymStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropAggregateStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropAssemblyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropApplicationRoleStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropFullTextCatalogStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropFullTextIndexStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropLoginStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropRoleStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropTypeStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropUserStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropMasterKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropSymmetricKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropAsymmetricKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropCertificateStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropCredentialStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterPartitionFunctionStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterPartitionSchemeStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterFullTextIndexStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterFullTextIndexAction node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SimpleAlterFullTextIndexAction node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SetStopListAlterFullTextIndexAction node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SetSearchPropertyListAlterFullTextIndexAction node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropAlterFullTextIndexAction node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AddAlterFullTextIndexAction node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterColumnAlterFullTextIndexAction node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateSearchPropertyListStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterSearchPropertyListStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SearchPropertyListAction node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AddSearchPropertyListAction node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropSearchPropertyListAction node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropSearchPropertyListStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateLoginStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateLoginSource node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(PasswordCreateLoginSource node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(PrincipalOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OnOffPrincipalOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(LiteralPrincipalOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(IdentifierPrincipalOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(WindowsCreateLoginSource node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CertificateCreateLoginSource node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AsymmetricKeyCreateLoginSource node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(PasswordAlterPrincipalOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterLoginStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterLoginOptionsStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterLoginEnableDisableStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterLoginAddDropCredentialStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RevertStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropContractStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropEndpointStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropMessageTypeStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropQueueStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropRemoteServiceBindingStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropRouteStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropServiceStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SignatureStatementBase node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AddSignatureStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropSignatureStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropEventNotificationStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExecuteAsStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(EndConversationStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(MoveConversationStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(GetConversationGroupStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ReceiveStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SendStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(WaitForSupportedStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterSchemaStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterAsymmetricKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterServiceMasterKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BeginConversationTimerStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BeginDialogStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DialogOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ScalarExpressionDialogOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OnOffDialogOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BackupCertificateStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BackupRestoreMasterKeyStatementBase node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BackupServiceMasterKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RestoreServiceMasterKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BackupMasterKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(RestoreMasterKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ScalarExpressionSnippet node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BooleanExpressionSnippet node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(StatementListSnippet node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SelectStatementSnippet node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SchemaObjectNameSnippet node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TSqlFragmentSnippet node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TSqlStatementSnippet node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(IdentifierSnippet node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TSqlScript node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TSqlBatch node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TSqlStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DataModificationStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DataModificationSpecification node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(MergeStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(MergeSpecification node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(MergeActionClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(MergeAction node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(UpdateMergeAction node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DeleteMergeAction node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(InsertMergeAction node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateTypeTableStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AuditSpecificationStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AuditSpecificationPart node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AuditSpecificationDetail node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AuditActionSpecification node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DatabaseAuditAction node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AuditActionGroupReference node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateDatabaseAuditSpecificationStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterDatabaseAuditSpecificationStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropDatabaseAuditSpecificationStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateServerAuditSpecificationStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterServerAuditSpecificationStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropServerAuditSpecificationStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ServerAuditStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateServerAuditStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterServerAuditStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropServerAuditStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AuditTarget node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AuditOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(QueueDelayAuditOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AuditGuidAuditOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OnFailureAuditOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(StateAuditOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AuditTargetOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(MaxSizeAuditTargetOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(MaxRolloverFilesAuditTargetOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(LiteralAuditTargetOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OnOffAuditTargetOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DatabaseEncryptionKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateDatabaseEncryptionKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterDatabaseEncryptionKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropDatabaseEncryptionKeyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ResourcePoolStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ResourcePoolParameter node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ResourcePoolAffinitySpecification node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateResourcePoolStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterResourcePoolStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropResourcePoolStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExternalResourcePoolStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExternalResourcePoolParameter node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ExternalResourcePoolAffinitySpecification node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateExternalResourcePoolStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterExternalResourcePoolStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropExternalResourcePoolStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(WorkloadGroupStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(WorkloadGroupResourceParameter node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(WorkloadGroupImportanceParameter node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(WorkloadGroupParameter node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateWorkloadGroupStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterWorkloadGroupStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropWorkloadGroupStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BrokerPriorityStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BrokerPriorityParameter node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateBrokerPriorityStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterBrokerPriorityStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropBrokerPriorityStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateFullTextStopListStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterFullTextStopListStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FullTextStopListAction node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropFullTextStopListStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateCryptographicProviderStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterCryptographicProviderStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropCryptographicProviderStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(EventSessionObjectName node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(EventSessionStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateEventSessionStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(EventDeclaration node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(EventDeclarationSetParameter node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SourceDeclaration node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(EventDeclarationCompareFunctionParameter node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TargetDeclaration node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SessionOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(EventRetentionSessionOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(MemoryPartitionSessionOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(LiteralSessionOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(MaxDispatchLatencySessionOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(OnOffSessionOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterEventSessionStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropEventSessionStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterResourceGovernorStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateSpatialIndexStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SpatialIndexOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SpatialIndexRegularOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BoundingBoxSpatialIndexOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(BoundingBoxParameter node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(GridsSpatialIndexOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(GridParameter node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CellsPerObjectSpatialIndexOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterServerConfigurationStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(ProcessAffinityRange node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterServerConfigurationSetBufferPoolExtensionStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterServerConfigurationBufferPoolExtensionOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterServerConfigurationBufferPoolExtensionContainerOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterServerConfigurationBufferPoolExtensionSizeOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterServerConfigurationSetDiagnosticsLogStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterServerConfigurationDiagnosticsLogOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterServerConfigurationDiagnosticsLogMaxSizeOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterServerConfigurationSetFailoverClusterPropertyStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterServerConfigurationFailoverClusterPropertyOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterServerConfigurationSetHadrClusterStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterServerConfigurationHadrClusterOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterServerConfigurationSetSoftNumaStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterServerConfigurationSoftNumaOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AvailabilityGroupStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateAvailabilityGroupStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterAvailabilityGroupStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AvailabilityReplica node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AvailabilityReplicaOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(LiteralReplicaOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AvailabilityModeReplicaOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(FailoverModeReplicaOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(PrimaryRoleReplicaOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SecondaryRoleReplicaOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AvailabilityGroupOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(LiteralAvailabilityGroupOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterAvailabilityGroupAction node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterAvailabilityGroupFailoverAction node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterAvailabilityGroupFailoverOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropAvailabilityGroupStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateFederationStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(AlterFederationStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DropFederationStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(UseFederationStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DiskStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(DiskStatementOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CreateColumnStoreIndexStatement node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(WindowFrameClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(WindowDelimiter node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(WithinGroupClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(SelectiveXmlIndexPromotedPath node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(TemporalClause node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }

        public virtual void Visit(CompressionDelayIndexOption node)
        {
            if (!this.VisitBaseType)
            {
                this.Visit((TSqlFragment)node);
            }
        }
    }
}