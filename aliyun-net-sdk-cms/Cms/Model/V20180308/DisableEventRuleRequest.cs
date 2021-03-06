/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Cms.Transform;
using Aliyun.Acs.Cms.Transform.V20180308;
using System.Collections.Generic;

namespace Aliyun.Acs.Cms.Model.V20180308
{
    public class DisableEventRuleRequest : RpcAcsRequest<DisableEventRuleResponse>
    {
        public DisableEventRuleRequest()
            : base("Cms", "2018-03-08", "DisableEventRule", "cms", "openAPI")
        {
        }

		private List<string> ruleNamess;

		private string ruleName;

		public List<string> RuleNamess
		{
			get
			{
				return ruleNamess;
			}

			set
			{
				ruleNamess = value;
				for (int i = 0; i < ruleNamess.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"RuleNames." + (i + 1) , ruleNamess[i]);
				}
			}
		}

		public string RuleName
		{
			get
			{
				return ruleName;
			}
			set	
			{
				ruleName = value;
				DictionaryUtil.Add(QueryParameters, "RuleName", value);
			}
		}

        public override DisableEventRuleResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DisableEventRuleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}