using System;
using UnityEngine;

namespace osg {

    public class EventProducer {
        private EventRepository eventRepository;

        public EventProducer(EventRepository eventRepository) {
            this.eventRepository = eventRepository;
        }

        public void produceChunkGenerateEvent(int chunkX, int chunkZ) {
            ChunkGenerateEvent chunkGenerateEvent = new ChunkGenerateEvent(chunkX, chunkZ);
            eventRepository.addEvent(chunkGenerateEvent);
            Debug.Log("Produced event: " + chunkGenerateEvent);
        }

        public void producePlayerFallingIntoVoidEvent(Vector3 position) {
            PlayerFallingIntoVoidEvent playerFallingIntoVoidEvent = new PlayerFallingIntoVoidEvent(position);
            eventRepository.addEvent(playerFallingIntoVoidEvent);
            Debug.Log("Produced event: " + playerFallingIntoVoidEvent);
        }

        public void produceNationCreationEvent(Nation nation) {
            NationCreationEvent nationCreationEvent = new NationCreationEvent(nation);
            eventRepository.addEvent(nationCreationEvent);
            Debug.Log("Produced event: " + nationCreationEvent);
        }

        public void produceNationJoinEvent(Nation nation, EntityId entityId) {
            NationJoinEvent nationJoinEvent = new NationJoinEvent(nation, entityId);
            eventRepository.addEvent(nationJoinEvent);
            Debug.Log("Produced event: " + nationJoinEvent);
        }

        public void produceNationLeaveEvent(Nation nation, EntityId entityId) {
            NationLeaveEvent nationLeaveEvent = new NationLeaveEvent(nation, entityId);
            eventRepository.addEvent(nationLeaveEvent);
            Debug.Log("Produced event: " + nationLeaveEvent);
        }

        public void producePawnSpawnEvent(Vector3 position, Pawn pawn) {
            PawnSpawnEvent pawnSpawnEvent = new PawnSpawnEvent(position, pawn);
            eventRepository.addEvent(pawnSpawnEvent);
            Debug.Log("Produced event: " + pawnSpawnEvent);
        }

        public void produceNationDisbandEvent(Nation nation) {
            NationDisbandEvent nationDisbandEvent = new NationDisbandEvent(nation);
            eventRepository.addEvent(nationDisbandEvent);
            Debug.Log("Produced event: " + nationDisbandEvent);
        }
    }
}