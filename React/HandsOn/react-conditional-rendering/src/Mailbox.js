import React from "react";

export default function Mailbox(props) {
  const unreadMessages = props.unreadMessage;
  return (
    <div>
      <h1>Hello!</h1>
      {unreadMessages > 0 && <h1>you have {unreadMessages} unread messages</h1>}
    </div>
  );
}
