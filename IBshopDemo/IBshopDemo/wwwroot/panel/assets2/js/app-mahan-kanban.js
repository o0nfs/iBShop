/**
 * App Mahan Kanban
 */

'use strict';

async function initKanban(companyCode) {
    let boards;
    let formData = new FormData();
    formData.append("companyCode", companyCode);
    ajaxCall('/Companies/kanbansjson', formData, Methods.GET)
        .then(jsonResult => {
            const kanbanResponse = jsonResult;
            boards = kanbanResponse;

            const kanban = new jKanban({
                element: '.kanban-wrapper_' + companyCode,
                gutter: '15px',
                widthBoard: '250px',
                dragItems: true,
                boards: boards,
                dragBoards: true,
                addItemButton: true,
                click: function (el) {
                    let element = el;
                    let title = element.getAttribute('data-eid')
                        ? element.querySelector('.kanban-text').textContent
                        : element.textContent,
                        label = element.getAttribute('data-badge-text'),
                        avatars = element.getAttribute('data-assigned');
                }
            });

            afterInit(companyCode);
        });


    //$.ajax('/Companies/kanbansjson/' + id)
    //    .done(function (kanbansJson) {
    //        //const kanbanResponse = await fetch(assetsPath + 'json/kanban_' + id + '.json');
    //        const kanbanResponse = kanbansJson;
    //        //if (!kanbanResponse.ok) {
    //        //    console.error('error', kanbanResponse);
    //        //}
    //        //boards = await kanbanResponse.json();
    //        boards = kanbanResponse;

    //        const kanban = new jKanban({
    //            element: '.kanban-wrapper_' + id,
    //            gutter: '15px',
    //            widthBoard: '250px',
    //            dragItems: true,
    //            boards: boards,
    //            dragBoards: true,
    //            addItemButton: true,
    //            click: function (el) {
    //                let element = el;
    //                let title = element.getAttribute('data-eid')
    //                    ? element.querySelector('.kanban-text').textContent
    //                    : element.textContent,
    //                    label = element.getAttribute('data-badge-text'),
    //                    avatars = element.getAttribute('data-assigned');
    //            }
    //        });

    //        afterInit(id);
    //    });

}

function renderAvatar(images, pullUp, size, margin, members) {
    var $transition = pullUp ? ' pull-up' : '',
        $size = size ? 'avatar-' + size + '' : '',
        member = members == undefined ? ' ' : members.split(',');

    return images == undefined
        ? ' '
        : images
            .split(',')
            .map(function (img, index, arr) {
                var $margin = margin && index !== arr.length - 1 ? ' me-' + margin + '' : '';

                return (
                    "<div class='avatar " +
                    $size +
                    $margin +
                    "'" +
                    "data-bs-toggle='tooltip' data-bs-placement='top'" +
                    "title='" +
                    member[index] +
                    "'" +
                    '>' +
                    "<img src='" +
                    assetsPath +
                    'img/avatars/' +
                    img +
                    "' alt='Avatar' class='rounded-circle " +
                    $transition +
                    "'>" +
                    '</div>'
                );
            })
            .join(' ');
}

function renderHeader(color, text, companyCode,companyId) {
    return (
        "<div class='d-flex justify-content-between flex-wrap align-items-center mb-2 pb-1'>" +
        "<div class='item-badges'> " +
        "<div class='badge rounded-pill bg-label-" +
        color +
        "'> " +
        text +
        '</div>' +
        '</div>' +
        renderDropdown(companyCode, companyId) +
        '</div>'
    );
}

function renderBoardDropdown() {
    return (
        "<div class='dropdown'>" +
        "<i class='dropdown-toggle ti ti-dots-vertical cursor-pointer' id='board-dropdown' data-bs-toggle='dropdown' aria-haspopup='true' aria-expanded='false'></i>" +
        "<div class='dropdown-menu dropdown-menu-end' aria-labelledby='board-dropdown'>" +
        "<a class='dropdown-item delete-board' href='javascript:void(0)'> <i class='ti ti-trash ti-xs' me-1></i> <span class='align-middle'>Delete</span></a>" +
        "<a class='dropdown-item' href='javascript:void(0)'><i class='ti ti-edit ti-xs' me-1></i> <span class='align-middle'>Rename</span></a>" +
        "<a class='dropdown-item' href='javascript:void(0)'><i class='ti ti-archive ti-xs' me-1></i> <span class='align-middle'>Archive</span></a>" +
        '</div>' +
        '</div>'
    );
}

function renderDropdown(companyCode, companyId) {
    return (
        `<div class='dropdown kanban-tasks-item-dropdown'>
        <i class='dropdown-toggle ti ti-dots-vertical' id='kanban-tasks-item-dropdown' data-bs-toggle='dropdown' aria-haspopup='true' aria-expanded='false'></i>
        <div class='dropdown-menu dropdown-menu-end' aria-labelledby='kanban-tasks-item-dropdown'>
        <a class='dropdown-item' href='/Companies/CreateCompany?companyCode=${companyCode}'>Edit Company</a>
        <a class='dropdown-item' onclick="confirmDeleteCompany('${companyCode}','null')">Delete Company</a>
        <a class='dropdown-item' onclick="comingSoonAlert('Clone Company')">Clone Company</a>
        <a class='dropdown-item' onclick="comingSoonAlert('View Full Detail')">View Full Detail</a>
        <a class='dropdown-item' href='/Companies/CreateBranch?branchCode=${companyCode}'>Create New Branch</a>       
        <a class='dropdown-item border-top' href='/FinancialPeriods/Create?companyCode=${companyCode}'>Financial Period</a>
        <a class='dropdown-item' onclick="comingSoonAlert('Master Data')">Master Data</a>        
        <a class='dropdown-item border-top' href='/Users/Index'>User Management</a> 
        <a class='dropdown-item' onclick="ShowGUID('Company','${companyId}','${companyCode}')">Show ID</a>
        </div>
        </div>`
    );
}

function renderFooter(attachments, comments, assigned, members) {
    return (
        `<div class='d-flex justify-content-between align-items-center flex-wrap mt-2 pt-1'>
            <div class='d-flex'> 
                 <span class='d-flex align-items-center me-4'>
                    <i class='ti ti-building ti-xs'></i>
                    <span class='attachments'>
                    ${attachments}
                    </span>
                 </span> 
                 <span class='d-flex align-items-center me-4'>
                     <i class='ti ti-briefcase ti-xs'></i>
                     <span>
                     ${comments}
                     </span>
                 </span>
                 <span class='d-flex align-items-center'>
                     <i class='ti ti-users ti-xs'></i>
                     <span>
                     ${assigned}
                     </span>
                 </span>
            </div>
            
        </div>`

        //"<div class='d-flex justify-content-between align-items-center flex-wrap mt-2 pt-1'>" +
        //"<div class='d-flex'> <span class='d-flex align-items-center me-2'><i class='ti ti-paperclip ti-xs me-1'></i>" +
        //"<span class='attachments'>" +
        //attachments +
        //'</span>' +
        //"</span> <span class='d-flex align-items-center ms-1'><i class='ti ti-message-dots ti-xs me-1'></i>" +
        // '<span> ' +
        //comments +
        // ' </span>' +
        //   '</span></div>' +
        // "<div class='avatar-group d-flex align-items-center assigned-avatar'>" +
        //renderAvatar(assigned, true, 'xs', null, members) +
        //  '</div>' +
        //  '</div>'
    );
}

function afterInit(companyCode) {
    const kanbanWrapper = document.querySelector('.kanban-wrapper_' + companyCode),
        assetsPath = document.querySelector('html').getAttribute('data-assets-path');

    if (kanbanWrapper) {
        new PerfectScrollbar(kanbanWrapper);
    }

    const kanbanContainer = document.querySelector('.kanban-wrapper_' + companyCode + ' .kanban-container'),
        kanbanTitleBoard = [].slice.call(document.querySelectorAll('.kanban-wrapper_' + companyCode + ' .kanban-title-board')),
        kanbanItem = [].slice.call(document.querySelectorAll('.kanban-wrapper_' + companyCode + ' .kanban-item'));

    if (kanbanItem) {
        kanbanItem.forEach(function (el) {
            //console.log(el);
            const element = "<span class='kanban-text'>" + el.textContent + '</span>';
            let img = '';
            if (el.getAttribute('data-image') !== null) {
                img =
                    "<img alt class='img-fluid rounded mb-2' src='" +
                    el.getAttribute('data-image') +
                    "'>";
            }
            el.textContent = '';
            if (el.getAttribute('data-color') !== undefined && el.getAttribute('data-label') !== undefined) {
                el.insertAdjacentHTML(
                    'afterbegin',
                    renderHeader(el.getAttribute('data-color'),
                        el.getAttribute('data-label'),
                        el.getAttribute('data-idguid'),
                        el.getAttribute('data-idvalue'),
                    )
                    + img + element
                );
            }
            if (
                el.getAttribute('data-comments') !== undefined ||
                el.getAttribute('data-due-date') !== undefined ||
                el.getAttribute('data-assigned') !== undefined
            ) {
                el.insertAdjacentHTML(
                    'beforeend',
                    renderFooter(
                        el.getAttribute('data-attachments'),
                        el.getAttribute('data-comments'),
                        el.getAttribute('data-assigned'),
                        el.getAttribute('data-members')
                    )
                );
            }
        });
    }

    const tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'));
    tooltipTriggerList.map(function (tooltipTriggerEl) {
        return new bootstrap.Tooltip(tooltipTriggerEl);
    });

    const tasksItemDropdown = [].slice.call(document.querySelectorAll('.kanban-wrapper_' + companyCode + ' .kanban-tasks-item-dropdown'));
    if (tasksItemDropdown) {
        tasksItemDropdown.forEach(function (e) {
            e.addEventListener('click', function (el) {
                el.stopPropagation();
            });
        });
    }
}

function fetchGuidFromString(str) {
    var regex = /\b[a-f0-9]{8}\b-[a-f0-9]{4}-[a-f0-9]{4}-[a-f0-9]{4}-\b[a-f0-9]{12}\b/gi;
    var GUID = str.match(regex);
    return GUID;
   
    
}