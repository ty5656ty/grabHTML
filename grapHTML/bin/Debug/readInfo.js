var current;
var goal;
var percent;
var remain;
var listid;
var max;
var lis;

function getinfo() {
    var div = document.getElementsByClassName('project-goal')[0];
    var h3 = div.getElementsByTagName('h3')[0];
    var span = h3.getElementsByTagName('span')[0];
    current = span.innerText;
    var p = div.getElementsByClassName('clearfloat')[0];
    span = p.getElementsByClassName('goal-money')[0];
    goal = span.innerText;
    span = p.getElementsByClassName('percent')[0];
    percent = span.innerText;
    div = document.getElementsByClassName('remain-time')[0];
    h3 = div.getElementsByTagName('h3')[0];
    remain = h3.innerText;
}

function getcurrent() {
    return current;
}

function getgoal() {
    return goal;
}

function getpercent() {
    return percent;
}

function getremain() {
    return remain;
}

function getcomment(index) {
	listid = [];
    var ul = document.getElementsByClassName('comment-lists')[1];
	lis = ul.getElementsByTagName("li");
	var id;
    for (var i = 0; i < lis.length; i++)
    {
		id = lis[i].getAttribute('data-reply-id');
		if (id > index)
		{
			listid.push(id);
		}
	}
	max = lis[0].getAttribute('data-reply-id')
	return max;
}

function getlistid() {
	return JSON.stringify(listid);
}

function getidinfo(id) {
	var str;
	var p = lis[max - id].getElementsByClassName("nickname")[0];
	var a = p.getElementsByTagName("a")[0];
	var i = lis[max - id].getElementsByClassName("icon-payment")[0];
	var div = i.parentNode;
	return a.innerText + div.innerText;
}