const SEARCH_ROLES = _baseUrl + "/Security/Roles/Search";


function loadRoleGrid(name, description) {
    var columns = [
        { "title": "Role Id", "data": "roleId", "visible": false },
        { "title": name, "data": "name" },
        { "title": description, "data": "description" }
        //,{
        //    "title": operations, "data": "roleId", "class": "gridData-CenterAlign", "sortable": false,
        //    "render": function (institutionId, type, full, meta) {
        //        var operations = '<a title="' + edit + '" href="/Tenancy/Edit/' + institutionId + '"><i class="fa fa-edit" aria-hidden="true"></i></a>';
        //        return operations;
        //    }
        //}
    ];

    var table = createDataTablesGrid("RoleGrid", columns, SEARCH_ROLES, 1, 'asc');
}

function createDataTablesGrid(tableName, columns, searchUrl, defaultSortColumnIndex, sortOrder) {
    if (sortOrder == undefined) {
        sortOrder = 'asc';
    }

    $("#" + tableName).show();

    var grid = $("#" + tableName);

    var dataTable = grid.DataTable({
        "searching": false,
        "ordering": true,
        "processing": true,
        "stateSave": false,
        "searchDelay": 800,
        "responsive": true,
        "info": true,
        "pagingType": "full_numbers",
        //"language": {
        //    "paginate": {
        //        "first": _gridPageFirst,
        //        "previous": _gridPagePrevious,
        //        "next": _gridPageNext,
        //        "last": _gridPageLast
        //    }
        //},
        "lengthMenu": [10, 20, 50, 100],
        "pageLength": 10,
        "order": [[defaultSortColumnIndex, sortOrder]],
        "fixedHeader": {
            header: true,
            footer: false,
            headerOffset: 50,
            footerOffset: 0
        },
        "serverSide": true,
        "serverData": function (sSource, aoData, fnCallback) {
            var sortColIndex = aoData[2].value[0].column;
            var sortDirection = aoData[2].value[0].dir;
            var sortAscending = sortDirection == "asc";
            var sortColumn = aoData[1].value[sortColIndex].data;
            var skip = aoData[3].value;
            var take = aoData[4].value;

            aoData.push({ "name": "SortColumn", "value": sortColumn });
            aoData.push({ "name": "SortDirection", "value": sortDirection });
            aoData.push({ "name": "SortAscending", "value": sortAscending });
            aoData.push({ "name": "Skip", "value": skip });
            aoData.push({ "name": "Take", "value": take });

            var fullTextSearchValue = aoData[5].value.value;
            aoData.push({ "name": "Search_FullText", "value": fullTextSearchValue });
            $("[id^='Search_']").each(function (index, element) {
                aoData.push({ "name": element.id.replace("Search_", ""), "value": $(element).val() });
            });

            if ($('#checkAll').length > 0) {
                $('#checkAll').prop('checked', false);
            }

            $.ajax({ "dataType": "json", "type": "post", "url": searchUrl, "data": aoData, "success": fnCallback, "error": function (xhr) { /*handleErrors(xhr); */ console.log(xhr); } });
        },
        "columns": columns,
        "language": { "zeroRecords": "There were no records found at this time." }

    });

    return dataTable;
}