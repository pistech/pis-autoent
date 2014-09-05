﻿
Ext.define('PIS.model.sys.org.Function', {
    extend: 'Ext.data.Model',

    idProperty: 'Id',

    fields: [
        { name: 'Id', type: 'string' },
        { name: 'Code', type: 'string' },
        { name: 'Name', type: 'string' },
        { name: 'Type', type: 'string' },
        { name: 'Status', type: 'string', defaultValue: 'Enabled' },
        { name: 'Description', type: 'string' },
        { name: 'Tag', type: 'string' }
    ],

    validations: [
        { type: 'length', field: 'Code', min: 2 },
        { type: 'length', field: 'Name', min: 2 }
    ]
});