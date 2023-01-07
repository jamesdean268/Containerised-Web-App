import React from 'react';

// ------ LEARNING CODE ADDITION ------
// Add a component that will fetch a list of items from the backend API and render them in an unordered list.

class ItemList extends React.Component {
  state = {
    items: []
  };

  componentDidMount() {
    fetch('api/Item')
      .then(res => res.json())
      .then(items => this.setState({ items }));
  }

  render() {
    return (
      <div>
        <h1>Item List</h1>
        <ul>
          {this.state.items.map(item => (
            <li key={item.id}>{item.name}</li>
          ))}
        </ul>
      </div>
    );
  }
}

export default ItemList;
