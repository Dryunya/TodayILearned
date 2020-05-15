import React from 'react';
import Header from './Header'
import Item from './Item'

const ToDo = () => {
    return (
        <>
            <div className="section">
                <Header />
            </div>
            <div className="section">
                <Item />
                <Item />
                <Item />
            </div>
        </>
    );
}

export default ToDo;