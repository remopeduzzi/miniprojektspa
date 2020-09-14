import React, {Component} from 'react';
import NoteList from './Components/NoteList';
import './App.css';



class App extends Component {


  render() {return (
      <NoteList notes={this.state.notes}/>

  )}
  state = {
    notes: []
  }
  componentDidMount() {

    fetch("http://localhost:5000/api/notes")
        .then(response => response.json())
        .then((data) => {this.setState({ notes: data})
        })

  }

}
export default App;
