import { useContext, createContext, useState, useEffect } from "react";
//create context
const UserContext = createContext("Unknown");
//provider context
const Application = () => {
  //const userName = "John Smith";
  //2.change the context value(after 10 sec Context value changes to Smith, John Smith)
  const [userName, setUserName] = useState("John Smith");
  useEffect(() => {
    setTimeout(() => {
      setUserName("Smith, John Smith");
    }, 10000);
  }, []);

  return (
    <UserContext.Provider value={userName}>
      <Layout children="Main Content"></Layout>
    </UserContext.Provider>
  );
};
function Layout({ children }) {
  return (
    <div>
      <Header />
      <main>{children}</main>
    </div>
  );
}
function Header() {
  return (
    <>
      <UserInfo />
    </>
  );
}
//consumer context
function UserInfo() {
  const userName = useContext(UserContext);
  return <div>{userName}</div>;
}
export default Application;
