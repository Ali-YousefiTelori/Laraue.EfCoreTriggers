﻿using System;
using System.Linq.Expressions;
using Laraue.EfCoreTriggers.Common.TriggerBuilders.Base;

namespace Laraue.EfCoreTriggers.Common.TriggerBuilders.OnInsert
{
    public class OnInsertTriggerDeleteAction<TTriggerEntity, TDeleteEntity> : TriggerDeleteAction
        where TTriggerEntity : class
        where TDeleteEntity : class
    {
        public OnInsertTriggerDeleteAction(Expression<Func<TTriggerEntity, TDeleteEntity, bool>> deleteFilter)
            : base (deleteFilter)
        {
        }

        internal override ArgumentTypes DeleteFilterPrefixes => new()
        {
            [DeletePredicate.Parameters[0].Name] = ArgumentType.New,
        };
    }
}
