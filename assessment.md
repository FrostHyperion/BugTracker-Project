// First Question
interface Type {
}

class BugReport : Type {
}

class ServiceRequest : Type {
}

class TicketTypeContext {
	Type Type;

	SetTicketType(Type type){
		Type = type;
	}
}

class Ticket : TicketTypeContext {
	Type Type;

	SetTicketType(Type type){
		Type = type;
	}
}


// Second Question
abstract class Deadline {
	// base deadline
	int time = 24;
	public abstract int Time();
}

class ResponseDeadline : Deadline {
	// response time
	int responsetime = 12;
	public abstract int Time(){
		return responsetime + time;
	}
}

class BreachDeadline : Deadline {
	// breach time
	int breachtime = 12;
	public abstract int Time(){
		return breachtime + time;
	}
}

class Ticket {
	Deadline deadline;
	deadline = new ResponseDeadline(deadline);
	deadline = new BreadDeadline(deadline);
}

