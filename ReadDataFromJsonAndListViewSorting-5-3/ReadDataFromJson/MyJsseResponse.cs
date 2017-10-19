using System;
using System.Collections.Generic;

namespace ReadDataFromJson
{
    public class MyJsseResponse
    {

		public class Observee
		{
			public object CompanyId { get; set; }
			public object Dept_Id { get; set; }
			public object Email { get; set; }
			public int Emp_Id { get; set; }
			public object FirstName { get; set; }
			public string FullName { get; set; }
			public object LastName { get; set; }
			public object MajorGroup_Id { get; set; }
			public object Org_Id { get; set; }
			public object Section_Id { get; set; }
			public int SecurityUserID { get; set; }
			public object UserTitle { get; set; }
			public object User_ID { get; set; }
		}

		public class Observer
		{
			public object CompanyId { get; set; }
			public object Dept_Id { get; set; }
			public object Email { get; set; }
			public int Emp_Id { get; set; }
			public object FirstName { get; set; }
			public string FullName { get; set; }
			public object LastName { get; set; }
			public object MajorGroup_Id { get; set; }
			public object Org_Id { get; set; }
			public object Section_Id { get; set; }
			public int SecurityUserID { get; set; }
			public object UserTitle { get; set; }
			public string User_ID { get; set; }
		}

		public class RootObjectJSSE
		{
			public object Attachments { get; set; }
			public string Base64_JSSE_ID { get; set; }
			public object Categories { get; set; }
			public DateTime CreatedDate { get; set; }
			public int Dept_Id { get; set; }
			public int Hierarchy_ID { get; set; }
			public bool IsAnonymous { get; set; }
			public bool IsCreator { get; set; }
			public bool IsExternal { get; set; }
			public DateTime JSSEDate { get; set; }
			public string JSSEEnteredBy { get; set; }
			public string JSSEStatus { get; set; }
			public object JSSETitle { get; set; }
			public int JSSE_ID { get; set; }
			public object JobDescription { get; set; }
			public object JobName { get; set; }
			public object Location { get; set; }
			public int MajorGroup_Id { get; set; }
			public int Observee_ID { get; set; }
			public List<Observee> Observees { get; set; }
			public Observer Observer { get; set; }
			public int Observer_ID { get; set; }
			public object Observers { get; set; }
			public int Org_Id { get; set; }
			public string Region { get; set; }
			public int Region_ID { get; set; }
			public int Section_Id { get; set; }
			public object SelObservees { get; set; }
			public object SelObservers { get; set; }
		}
    }
}
