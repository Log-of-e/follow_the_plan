using System;

namespace proto_refactor_anonymous
{
  public class follow_resource_plan
	{


		public follow_resource_plan ()
		{
		}
	}



	public  class taskTimer{
		int duration;
		list<taskAbst> handOffList;
		protected 
	}

	public class  sequential : proto_refactor_anonymous.taskAbst {
	

	}

	public class globalResourceTimer{

		public int maxDuration(List<taskTimer> _parallelTasks){}

		public int returnTimings(taskTimer _taskToDo){}




	}

	public class timingForTask{

		int _startTime;
		int _stopTime;
		int _duration;

		public timingForTask(int start, int duration){
			_startTime=start;
			_duration=duration;
			_stopTime=start+duration;

			//stopTime;
		}

		public int stopTime {
			get {//_stopTime=duration+startTime;
				return _stopTime;}
			set {_stopTime =_duration+value;}
		}

	}


}

