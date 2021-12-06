import React, { useEffect, useState } from 'react';
import './App.css';
import { UserService } from './services/UserService';
import { User } from './models/User';

function App() {

  const [users, setUsers] = useState<User[]>([]);

  const userService = new UserService();
  useEffect(() => {
    userService.get().then(res => {
      let users: any = res;
      setUsers(users);
    });

  }, [])
  return (
    <div className="App">
      I'm here
      <ul>
        {users && users.map(p =>
          <li key={p.id}>
              {p.id} -  {p.userName} - {p.password}
          </li>)}
      </ul>
    </div>
  );
}

export default App;
